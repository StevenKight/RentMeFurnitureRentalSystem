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
DELIMITER ;