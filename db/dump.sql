CREATE DATABASE  IF NOT EXISTS `cs3230f23d` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `cs3230f23d`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 160.10.217.6    Database: cs3230f23d
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ 'f6b27acf-3a68-11eb-8944-000c29f23569:1-44592';

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES ('Accent'),('Antique and Vintage'),('Art Deco'),('Bar and Wine'),('Bathroom'),('Bedroom'),('Bohemian'),('Children\'s'),('Contemporary'),('Dining Room'),('Entryway and Hallway'),('Home Entertainment'),('Home Office'),('Industrial'),('Kitchen'),('Living Room'),('Mid-Century Modern'),('Minimalist'),('Outdoor'),('Patio'),('Rustic and Farmhouse'),('Scandinavian'),('Storage and Organization'),('Traditional'),('Upholstered');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `member_id` int NOT NULL AUTO_INCREMENT,
  `fname` varchar(45) NOT NULL,
  `lname` varchar(45) NOT NULL,
  `dob` date NOT NULL,
  `gender` char(1) NOT NULL,
  `email` varchar(45) NOT NULL,
  `phone` char(12) NOT NULL,
  `address` varchar(45) NOT NULL,
  `city` varchar(45) NOT NULL,
  `state` varchar(45) NOT NULL,
  `zip` varchar(45) NOT NULL,
  `register_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`member_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (2,'Fake','Customer','2023-10-15','F','fake@gmail.com','111-222-4444','Fake street','Fake city','Alabama','11111','2023-10-15 21:06:00'),(9,'Test','Update','1983-10-27','O','asdf@asdf.com','433-454-4562','3rd','rangeds','Mississippi','30291','2023-10-27 08:31:22'),(10,'frank','smith','2005-10-27','O','frank@gmail.com','546-342-3421','3rd street','jones citiy','Alabama','40543','2023-10-27 08:34:09'),(11,'test','test','2023-10-30','M','test@test.test','111-222-4444','Test','test','Alabama','12345','2023-10-30 15:01:56'),(12,'Joe','Smith','2000-02-08','M','joeSmith@gmail.com','770-456-2312','street 123','locust grove','Georgia','30248','2023-11-26 22:23:22');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `employee_num` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `fname` varchar(45) NOT NULL,
  `lname` varchar(45) NOT NULL,
  `gender` varchar(45) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `dob` date DEFAULT NULL,
  `address` varchar(45) NOT NULL,
  `city` varchar(45) NOT NULL,
  `state` varchar(45) NOT NULL,
  `zip` varchar(45) NOT NULL,
  `role_name` varchar(45) NOT NULL,
  PRIMARY KEY (`employee_num`),
  KEY `username` (`username`),
  KEY `role_name` (`role_name`),
  CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`username`) REFERENCES `login` (`username`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `employee_ibfk_2` FOREIGN KEY (`role_name`) REFERENCES `role` (`name`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'sk00039','Steven','Kight','M','706-346-7899','sk00039@my.westga.edu','2002-07-11','602 South Park St Unit 1','Carrollton','Georgia','30117','administrator'),(4,'cwill124','corey','williams','M','333-333-3333','email@main.com','2023-10-25','12 dasfs','franklin','Georgia','30218','administrator'),(11,'hash','test','test','O','555-444-3333','test@gmail.com','2023-11-12','123 street','city','Alabama','39012','employee'),(12,'hash 2','admin','hash','O','222-222-1111','hash@gmail.com','2023-11-12','342 drive','city','Alabama','30291','administrator');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `furniture`
--

DROP TABLE IF EXISTS `furniture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `furniture` (
  `furniture_id` int NOT NULL AUTO_INCREMENT,
  `category_name` varchar(45) NOT NULL,
  `style_name` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(255) NOT NULL,
  `rental_rate` decimal(10,2) NOT NULL,
  `fine_rate` decimal(10,2) NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`furniture_id`),
  KEY `fk_furniture_category` (`category_name`),
  KEY `fk_furniture_style` (`style_name`),
  CONSTRAINT `fk_furniture_category` FOREIGN KEY (`category_name`) REFERENCES `category` (`name`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_furniture_style` FOREIGN KEY (`style_name`) REFERENCES `style` (`name`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `furniture`
--

LOCK TABLES `furniture` WRITE;
/*!40000 ALTER TABLE `furniture` DISABLE KEYS */;
INSERT INTO `furniture` VALUES (1,'Kitchen','Asian','table chair','a kitchen chair',12.99,34.99,3),(2,'Accent','Antique','test','test',12.12,32.12,2),(3,'Accent','Antique','test 2','test',32.12,45.32,4),(4,'Accent','Antique','desk','test',21.12,34.32,3),(5,'Kitchen','Farmhouse','table','this is a table',43.00,21.00,27);
/*!40000 ALTER TABLE `furniture` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `username` varchar(45) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES ('cwill124','AQAAAAIAAYagAAAAELi55QO4avHMCPAZ6sJskJ4f1SGrYA5dqaEdQ7cLTPeexYT+gnsNOmH+zTPlWo9qGQ=='),('hash','AQAAAAIAAYagAAAAEI7UZlNroXFHSPxZW6JOtA24NyMY2aQylTO55ySRtQrbOFuFQEK4lN93jbN3w+bjAg=='),('hash 2','AQAAAAIAAYagAAAAEKg8mHgv/Xy50hBeVeUs/te7mI/o5IT68RbJAYsdGrvJAYmNzHqtOPRXyjNM0RYPRw=='),('sk00039','AQAAAAIAAYagAAAAECYRjYGS/0cjcwDN+jlk3UkrRecNdEIrBKYXFgtSsHkvHAQqpDzy8CaJsvXiDhlnXw==');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rental`
--

DROP TABLE IF EXISTS `rental`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rental` (
  `rental_id` int NOT NULL AUTO_INCREMENT,
  `member_id` int NOT NULL,
  `employee_num` int NOT NULL,
  `start_date` date NOT NULL,
  `due_date` date NOT NULL,
  PRIMARY KEY (`rental_id`),
  KEY `member_id` (`member_id`),
  KEY `employee_num` (`employee_num`),
  CONSTRAINT `rental_ibfk_1` FOREIGN KEY (`member_id`) REFERENCES `customer` (`member_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `rental_ibfk_2` FOREIGN KEY (`employee_num`) REFERENCES `employee` (`employee_num`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rental`
--

LOCK TABLES `rental` WRITE;
/*!40000 ALTER TABLE `rental` DISABLE KEYS */;
INSERT INTO `rental` VALUES (22,10,1,'2023-11-12','2024-04-10'),(23,10,1,'2023-11-12','2024-03-12'),(24,10,1,'2023-11-13','2023-11-23'),(28,12,4,'2023-11-26','2023-12-08'),(29,12,4,'2023-11-26','2023-12-04'),(30,12,4,'2023-11-26','2023-12-04'),(31,9,1,'2023-11-26','2024-06-11'),(32,9,1,'2023-11-26','2024-06-18'),(33,10,4,'2023-11-26','2025-07-17'),(34,9,1,'2023-11-26','2024-06-19');
/*!40000 ALTER TABLE `rental` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rental_item`
--

DROP TABLE IF EXISTS `rental_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rental_item` (
  `rental_id` int NOT NULL,
  `furniture_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`rental_id`,`furniture_id`),
  KEY `furniture_id` (`furniture_id`),
  CONSTRAINT `rental_item_ibfk_1` FOREIGN KEY (`rental_id`) REFERENCES `rental` (`rental_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `rental_item_ibfk_2` FOREIGN KEY (`furniture_id`) REFERENCES `furniture` (`furniture_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rental_item`
--

LOCK TABLES `rental_item` WRITE;
/*!40000 ALTER TABLE `rental_item` DISABLE KEYS */;
INSERT INTO `rental_item` VALUES (22,1,6),(22,5,3),(23,5,1),(24,2,2),(28,3,1),(28,5,1),(29,3,1),(30,3,1),(31,1,2),(31,5,1),(32,1,2),(32,5,1),(33,5,1),(34,1,2),(34,5,1);
/*!40000 ALTER TABLE `rental_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `return`
--

DROP TABLE IF EXISTS `return`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `return` (
  `return_id` int NOT NULL AUTO_INCREMENT,
  `member_id` int NOT NULL,
  `employee_num` int NOT NULL,
  `return_date` date NOT NULL,
  PRIMARY KEY (`return_id`),
  KEY `member_id` (`member_id`),
  KEY `employee_num` (`employee_num`),
  CONSTRAINT `return_ibfk_1` FOREIGN KEY (`member_id`) REFERENCES `customer` (`member_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `return_ibfk_2` FOREIGN KEY (`employee_num`) REFERENCES `employee` (`employee_num`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `return`
--

LOCK TABLES `return` WRITE;
/*!40000 ALTER TABLE `return` DISABLE KEYS */;
INSERT INTO `return` VALUES (23,10,1,'2023-11-13'),(24,10,1,'2023-11-13'),(25,10,1,'2023-11-13'),(26,10,4,'2023-11-26'),(27,10,4,'2023-11-26'),(28,12,4,'2023-11-26'),(30,12,1,'2023-11-26'),(31,9,1,'2023-11-26'),(32,9,1,'2023-11-26'),(33,10,4,'2023-11-26'),(34,9,1,'2023-11-26');
/*!40000 ALTER TABLE `return` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `return_item`
--

DROP TABLE IF EXISTS `return_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `return_item` (
  `rental_id` int NOT NULL,
  `furniture_id` int NOT NULL,
  `return_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`return_id`,`furniture_id`,`rental_id`),
  KEY `rental_id` (`rental_id`,`furniture_id`),
  CONSTRAINT `return_item_ibfk_1` FOREIGN KEY (`rental_id`, `furniture_id`) REFERENCES `rental_item` (`rental_id`, `furniture_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `return_item_ibfk_2` FOREIGN KEY (`return_id`) REFERENCES `return` (`return_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `return_item`
--

LOCK TABLES `return_item` WRITE;
/*!40000 ALTER TABLE `return_item` DISABLE KEYS */;
INSERT INTO `return_item` VALUES (22,1,25,2),(24,2,25,1),(23,5,26,1),(22,1,27,1),(30,3,28,1),(28,3,30,1),(31,1,31,2),(31,5,31,1),(32,1,32,2),(32,5,32,1),(33,5,33,1),(34,1,34,2),(34,5,34,1);
/*!40000 ALTER TABLE `return_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES ('administrator'),('employee');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `style`
--

DROP TABLE IF EXISTS `style`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `style` (
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `style`
--

LOCK TABLES `style` WRITE;
/*!40000 ALTER TABLE `style` DISABLE KEYS */;
INSERT INTO `style` VALUES ('Antique'),('Art Deco'),('Asian'),('Baroque'),('Bohemian'),('Coastal'),('Colonial'),('Contemporary'),('Cottage'),('Eclectic'),('Farmhouse'),('Gothic'),('Industrial'),('Mediterranean'),('Mid-Century Modern'),('Minimalist'),('Modern'),('Rococo'),('Rustic'),('Scandinavian'),('Shabby Chic'),('Traditional'),('Transitional'),('Tropical'),('Victorian'),('Vintage');
/*!40000 ALTER TABLE `style` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-26 23:01:46
