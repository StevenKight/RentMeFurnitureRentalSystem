DELIMITER $
CREATE PROCEDURE rentFurniture (IN memberId INT, employeeId INT, startDate DATE, dueDate DATE, furnitureId INT, furnitureQuantity INT)
BEGIN
	START TRANSACTION;
	INSERT INTO `rental`(member_id, employee_num, `start_date`, due_date)
		VALUES (memberId, employeeId, startDate, dueDate);

	INSERT INTO `rental_item`(rental_id, furniture_id, quantity)
		VALUES (
			(SELECT rental_id 
				FROM `rental` 
				WHERE member_id = memberId
				AND employee_num = employeeId 
				AND `start_date` = startDate
				AND due_date = dueDate),
			furnitureId, furnitureQuantity);

	COMMIT;
END$