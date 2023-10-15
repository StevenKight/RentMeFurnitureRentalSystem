-- Drop Tables
DROP TABLE IF EXISTS `return_item`;
DROP TABLE IF EXISTS `return`;
DROP TABLE IF EXISTS `rental_item`;
DROP TABLE IF EXISTS `rental`;
DROP TABLE IF EXISTS `furniture`;
DROP TABLE IF EXISTS `style`;
DROP TABLE IF EXISTS `category`;
DROP TABLE IF EXISTS `employee`;
DROP TABLE IF EXISTS `role`;
DROP TABLE IF EXISTS `customer`;
DROP TABLE IF EXISTS `login`;

-- Create Tables
CREATE TABLE `login`(
    username VARCHAR(45) PRIMARY KEY,
    `password` VARCHAR(45) NOT NULL
);

CREATE TABLE `customer`(
    member_id INT AUTO_INCREMENT PRIMARY KEY,
    fname VARCHAR(45) NOT NULL,
    lname VARCHAR(45) NOT NULL,
    dob DATE NOT NULL,
    gender CHAR(1) NOT NULL,
    email VARCHAR(45) NOT NULL,
    phone CHAR(12) NOT NULL,
    `address` VARCHAR(45) NOT NULL,
    city VARCHAR(45) NOT NULL,
    `state` VARCHAR(45) NOT NULL,
    zip VARCHAR(45) NOT NULL,
    register_date DATETIME NOT NULL DEFAULT NOW()
);

CREATE TABLE `role` (
    `name` VARCHAR(45) PRIMARY KEY
);

CREATE TABLE `employee` (
    employee_num INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(45) NOT NULL,
    fname VARCHAR(45) NOT NULL,
    lname VARCHAR(45) NOT NULL,
    gender VARCHAR(45) NOT NULL,
    phone VARCHAR(45) NOT NULL,
    email VARCHAR(45) NOT NULL,
    dob DATE NOT NULL,
    `address` VARCHAR(45) NOT NULL,
    city VARCHAR(45) NOT NULL,
    `state` VARCHAR(45) NOT NULL,
    zip VARCHAR(45) NOT NULL,
    role_name VARCHAR(45) NOT NULL,
    FOREIGN KEY (username)
        REFERENCES `login` (username)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (role_name)
        REFERENCES `role` (`name`)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE `category` (
    `name` VARCHAR(45) PRIMARY KEY
);

CREATE TABLE `style` (
    `name` VARCHAR(45) PRIMARY KEY
);

-- FIXME: Indexing on category_name and style_name?
    -- INDEX `fk_furniture_category_idx` (category_name ASC),
    -- INDEX `fk_furniture_style_idx` (style_name ASC),
CREATE TABLE `furniture` (
    furniture_id INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(45) NOT NULL,
    style_name VARCHAR(45) NOT NULL,
    `name` VARCHAR(45) NOT NULL,
    `description` VARCHAR(255) NOT NULL,
    rental_rate DECIMAL(10,2) NOT NULL,
    fine_rate DECIMAL(10,2) NOT NULL,
    quantity INT NOT NULL,
    CONSTRAINT `fk_furniture_category`
        FOREIGN KEY (category_name)
        REFERENCES `category` (`name`)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT `fk_furniture_style`
        FOREIGN KEY (style_name)
        REFERENCES `style` (`name`)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE `rental`(
    rental_id INT AUTO_INCREMENT PRIMARY KEY,
    member_id INT NOT NULL,
    employee_num INT NOT NULL,
    `start_date` DATE NOT NULL,
    due_date DATE NOT NULL,
    FOREIGN KEY (member_id)
        REFERENCES `customer` (member_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (employee_num)
        REFERENCES `employee` (employee_num)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE `rental_item`(
    rental_id INT NOT NULL,
    furniture_id INT NOT NULL,
    quantity INT NOT NULL,
    PRIMARY KEY (rental_id, furniture_id),
    FOREIGN KEY (rental_id)
        REFERENCES `rental` (rental_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (furniture_id)
        REFERENCES `furniture` (furniture_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE `return`(
    return_id INT AUTO_INCREMENT PRIMARY KEY,
    member_id INT NOT NULL,
    employee_num INT NOT NULL,
    `return_date` DATE NOT NULL,
    FOREIGN KEY (member_id)
        REFERENCES `customer` (member_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (employee_num)
        REFERENCES `employee` (employee_num)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE `return_item`(
    rental_id INT NOT NULL,
    furniture_id INT NOT NULL,
    return_id INT NOT NULL,
    quantity INT NOT NULL,
    PRIMARY KEY (return_id, furniture_id, rental_id),
    FOREIGN KEY (rental_id, furniture_id)
        REFERENCES `rental_item` (rental_id, furniture_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (return_id)
        REFERENCES `return` (return_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

INSERT INTO `role` (`name`)
VALUES ('administrator'),
	('employee');

INSERT INTO `category` (`name`)
VALUES ('Living Room'),
	('Bedroom'),
	('Dining Room'),
	('Kitchen'),
	('Home Office'),
	('Outdoor'),
	('Children''s'),
	('Home Entertainment'),
	('Entryway and Hallway'),
	('Bathroom'),
	('Patio'),
	('Bar and Wine'),
	('Accent'),
	('Storage and Organization'),
	('Upholstered'),
	('Antique and Vintage'),
	('Contemporary'),
	('Mid-Century Modern'),
	('Rustic and Farmhouse'),
	('Industrial'),
	('Minimalist'),
	('Scandinavian'),
	('Art Deco'),
	('Bohemian'),
	('Traditional');

INSERT INTO `style` (`name`)
VALUES ('Modern'),
	('Contemporary'),
	('Traditional'),
	('Mid-Century Modern'),
	('Rustic'),
	('Industrial'),
	('Scandinavian'),
	('Bohemian'),
	('Art Deco'),
	('Minimalist'),
	('Farmhouse'),
	('Coastal'),
	('Victorian'),
	('Shabby Chic'),
	('Transitional'),
	('Eclectic'),
	('Asian'),
	('Mediterranean'),
	('Tropical'),
	('Cottage'),
	('Colonial'),
	('Vintage'),
	('Antique'),
	('Gothic'),
	('Rococo'),
	('Baroque');