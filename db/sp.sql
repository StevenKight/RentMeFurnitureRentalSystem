DELIMITER $
CREATE PROCEDURE ChangePassword(
    IN inputUsername NVARCHAR(45),
    IN inputId INT,
    IN newPassword NVARCHAR(100)
)
BEGIN
    DECLARE recordCount INT;

    SELECT COUNT(*) INTO recordCount FROM employee WHERE employee_num = inputId AND username = inputUsername;

    IF recordCount = 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Record not found';
    ELSE
        UPDATE login SET password = newPassword WHERE username = inputUsername;
    END IF;
END $

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

CREATE PROCEDURE GetReturnableItems(rentalId INT, memberId INT)
BEGIN
    SELECT furniture.furniture_id, furniture.category_name, furniture.style_name, furniture.`name`, 
			furniture.`description`, furniture.rental_rate, rental_item.rental_id, rental_item.quantity
		FROM furniture, rental_item
		WHERE furniture.furniture_id=rental_item.furniture_id
			AND rental_item.rental_id=rentalId
			AND rental_item.furniture_id NOT IN (SELECT DISTINCT return_item.furniture_id
										FROM rental_item, return_item, `rental`, `return`
										WHERE return_item.furniture_id=rental_item.furniture_id
											AND return_item.return_id=`return`.return_id
											AND rental_item.rental_id=`rental`.rental_id
											AND `return`.member_id=`rental`.member_id
											AND return_item.rental_id = rentalId
											AND `rental`.member_id = memberId
											AND rental_item.quantity <= return_item.quantity);
END$
DELIMITER ;