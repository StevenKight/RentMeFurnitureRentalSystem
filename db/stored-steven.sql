DELIMITER $

CREATE PROCEDURE CreateRentalItem (rentalId INT, furnitureId INT, rentedQuantity INT)
BEGIN
    START TRANSACTION;

        INSERT INTO `rental_item`(rental_id, furniture_id, quantity)
            VALUES (rentalId, furnitureId, rentedQuantity);

        UPDATE furniture 
            SET quantity = quantity - rentedQuantity
            WHERE furniture_id = furnitureId;

    COMMIT;
END$

CREATE PROCEDURE CreateReturn (memberId INT, employeeNum INT, returnDate DATE, OUT returnId INT)
BEGIN
    INSERT INTO `return`(member_id, employee_num, `return_date`)
        VALUES (memberId, employeeNum, returnDate);

    SELECT LAST_INSERT_ID() AS new_return_id INTO returnId;
END$

CREATE PROCEDURE CreateReturnItem (rentalId INT, furnitureId INT, returnId INT, returnedQuantity INT)
BEGIN
    START TRANSACTION;

        INSERT INTO `cs3230f23d`.`return_item`(`rental_id`, `furniture_id`, `return_id`, `quantity`)
			VALUES (rentalId, furnitureId, returnId, returnedQuantity);

        UPDATE furniture 
            SET quantity = quantity + returnedQuantity
            WHERE furniture_id = furnitureId;

    COMMIT;
END$

CREATE PROCEDURE CreateRental (memberId INT, employeeNum INT, startDate DATE, dueDate DATE, OUT rentalId INT)
BEGIN
    INSERT INTO `rental`(member_id, employee_num, `start_date`, due_date)
        VALUES (memberId, employeeNum, startDate, dueDate);

    SELECT LAST_INSERT_ID() AS new_rental_id INTO rentalId;
END$

DELIMITER ;
