-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: polyclinic_db
-- ------------------------------------------------------
-- Server version	8.0.44

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

--
-- Table structure for table `appnts`
--

DROP TABLE IF EXISTS `appnts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appnts` (
  `appnt_id` int NOT NULL AUTO_INCREMENT,
  `appnt_date_time` datetime NOT NULL,
  `patients_patient_id` int NOT NULL,
  `doctors_doctor_id` int NOT NULL,
  `statuses_status_id` int NOT NULL,
  PRIMARY KEY (`appnt_id`),
  KEY `fk_appnts_patients1_idx` (`patients_patient_id`),
  KEY `fk_appnts_doctors1_idx` (`doctors_doctor_id`),
  KEY `fk_appnts_statuses1_idx` (`statuses_status_id`),
  CONSTRAINT `fk_appnts_doctors1` FOREIGN KEY (`doctors_doctor_id`) REFERENCES `doctors` (`doctor_id`),
  CONSTRAINT `fk_appnts_patients1` FOREIGN KEY (`patients_patient_id`) REFERENCES `patients` (`patient_id`),
  CONSTRAINT `fk_appnts_statuses1` FOREIGN KEY (`statuses_status_id`) REFERENCES `statuses` (`status_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appnts`
--

LOCK TABLES `appnts` WRITE;
/*!40000 ALTER TABLE `appnts` DISABLE KEYS */;
INSERT INTO `appnts` VALUES (1,'2025-11-27 08:00:00',1,3,2),(2,'2025-11-27 08:00:00',11,1,3),(3,'2025-11-27 09:00:00',2,1,2),(4,'2025-11-27 09:00:00',12,5,1),(5,'2025-11-27 10:00:00',3,5,2),(6,'2025-11-27 10:00:00',13,2,1),(7,'2025-11-27 11:00:00',4,2,2),(8,'2025-11-27 11:00:00',14,4,1),(9,'2025-11-27 12:00:00',5,4,2),(10,'2025-11-27 12:00:00',15,3,1),(11,'2025-11-27 13:00:00',6,1,2),(12,'2025-11-27 13:00:00',16,5,1),(13,'2025-11-27 14:00:00',7,2,2),(14,'2025-11-27 14:00:00',17,4,1),(15,'2025-11-27 15:00:00',8,3,2),(16,'2025-11-27 15:00:00',18,1,1),(17,'2025-11-27 16:00:00',9,5,2),(18,'2025-11-27 16:00:00',19,2,1),(19,'2025-11-27 17:00:00',10,4,2),(20,'2025-11-27 17:00:00',20,3,1),(21,'2025-12-24 10:45:00',7,3,1),(22,'2025-12-26 08:00:00',12,4,1),(23,'2025-12-29 10:45:00',17,4,1),(24,'2026-01-11 10:45:00',10,3,1);
/*!40000 ALTER TABLE `appnts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appnts_diagnosis`
--

DROP TABLE IF EXISTS `appnts_diagnosis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appnts_diagnosis` (
  `appnts_appnt_id` int NOT NULL,
  `diagnoses_diagnosis_id` int NOT NULL,
  PRIMARY KEY (`appnts_appnt_id`,`diagnoses_diagnosis_id`),
  KEY `fk_appnts_has_diagnoses_diagnoses1_idx` (`diagnoses_diagnosis_id`),
  KEY `fk_appnts_has_diagnoses_appnts1_idx` (`appnts_appnt_id`),
  CONSTRAINT `fk_appnts_has_diagnoses_appnts1` FOREIGN KEY (`appnts_appnt_id`) REFERENCES `appnts` (`appnt_id`),
  CONSTRAINT `fk_appnts_has_diagnoses_diagnoses1` FOREIGN KEY (`diagnoses_diagnosis_id`) REFERENCES `diagnoses` (`diagnosis_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appnts_diagnosis`
--

LOCK TABLES `appnts_diagnosis` WRITE;
/*!40000 ALTER TABLE `appnts_diagnosis` DISABLE KEYS */;
INSERT INTO `appnts_diagnosis` VALUES (2,1),(3,1),(11,1),(9,2),(19,2),(5,3),(17,3),(1,4),(15,4),(7,5),(13,5);
/*!40000 ALTER TABLE `appnts_diagnosis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnoses`
--

DROP TABLE IF EXISTS `diagnoses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnoses` (
  `diagnosis_id` int NOT NULL AUTO_INCREMENT,
  `icd_code` varchar(20) NOT NULL,
  `diagnosis_name` varchar(100) NOT NULL,
  `description` text,
  PRIMARY KEY (`diagnosis_id`),
  UNIQUE KEY `icd_code_UNIQUE` (`icd_code`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnoses`
--

LOCK TABLES `diagnoses` WRITE;
/*!40000 ALTER TABLE `diagnoses` DISABLE KEYS */;
INSERT INTO `diagnoses` VALUES (1,'I10','Есенціальна (первинна) гіпертензія','Високий кровяний тиск.'),(2,'H10','Кон’юнктивіт','Запалення кон’юнктиви.'),(3,'G44.1','Судинний головний біль','Мігрень, кластерний головний біль.'),(4,'L30','Дерматит неуточнений','Загальне запалення шкіри.'),(5,'J06','Гостра інфекція верхніх дихальних шляхів','ГРВІ, застуда.');
/*!40000 ALTER TABLE `diagnoses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctors`
--

DROP TABLE IF EXISTS `doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctors` (
  `doctor_id` int NOT NULL AUTO_INCREMENT,
  `last_name` varchar(100) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `specialties_specialty_id` int NOT NULL,
  PRIMARY KEY (`doctor_id`),
  KEY `fk_doctors_specialties_idx` (`specialties_specialty_id`),
  CONSTRAINT `fk_doctors_specialties` FOREIGN KEY (`specialties_specialty_id`) REFERENCES `specialties` (`specialty_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctors`
--

LOCK TABLES `doctors` WRITE;
/*!40000 ALTER TABLE `doctors` DISABLE KEYS */;
INSERT INTO `doctors` VALUES (1,'Коваленко','Ольга','067-111-2233',1),(2,'Дітвин','Дмитро','067-222-3344',3),(3,'Шевченко','Наталя','067-333-4455',2),(4,'Ткаченко','Ігор','067-444-5566',4),(5,'Христина','Марина','067-555-6677',5),(7,'Півоваров','Степан','050-001-0102',2);
/*!40000 ALTER TABLE `doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `patient_id` int NOT NULL AUTO_INCREMENT,
  `last_name` varchar(100) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `date_of_birth` date NOT NULL,
  `address` varchar(255) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`patient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (1,'Іванов','Петро','1985-05-15','Київ, пр-т Перемоги, 10','050-100-0001'),(2,'Сидорова','Олена','1992-11-20','Київ, вул. Хрещатик, 5','050-100-0002'),(3,'Мельник','Андрій','1970-03-01','Львів, пр-т Свободи, 1','050-100-0003'),(4,'Коваль','Тетяна','2001-07-25','Одеса, вул. Дерибасівська, 12','050-100-0004'),(5,'Зубко','Максим','1998-09-10','Київ, вул. Гната Юри, 3','050-100-0005'),(6,'Попова','Дар’я','1965-12-03','Київ, вул. Саксаганського, 8','050-100-0006'),(7,'Васильєв','Олександр','1980-01-20','Харків, вул. Сумська, 7','050-100-0007'),(8,'Лисенко','Яна','1995-04-18','Дніпро, Центральний пр-т, 4','050-100-0008'),(9,'Пінчук','Роман','1977-08-11','Київ, бульв. Шевченка, 6','050-100-0009'),(10,'Кузьменко','Надія','1989-02-14','Запоріжжя, пр-т Соборний, 9','050-100-0010'),(11,'Федоренко','Віктор','1960-06-22','Київ, бульв. Лесі Українки, 2','050-100-0011'),(12,'Гуляєва','Софія','2005-09-05','Київ, пр-т Науки, 14','050-100-0012'),(13,'Бойко','Володимир','1975-10-30','Чернігів, пр-т Миру, 15','050-100-0013'),(14,'Савчук','Ірина','1990-03-17','Полтава, Соборний Майдан, 16','050-100-0014'),(15,'Климчук','Дмитро','1982-11-08','Суми, вул. Коваленка, 17','050-100-0015'),(16,'Мартиненко','Оксана','1993-04-29','Київ, бульв. Дружби Народів, 18','050-100-0016'),(17,'Петренко','Сергій','1968-07-19','Рівне, вул. Київська, 19','050-100-0017'),(18,'Ткачук','Марія','1987-12-06','Житомир, пл. Перемоги, 20','050-100-0018'),(19,'Семенюк','Олег','1973-02-09','Луцьк, пр-т Волі, 21','050-100-0019'),(20,'Ярмоленко','Віра','1996-08-21','Тернопіль, вул. Шептицького, 22','050-100-0020'),(23,'Півоваров','Степан','2004-08-08','Моя адреса 22','050-20-20-20');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specialties`
--

DROP TABLE IF EXISTS `specialties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specialties` (
  `specialty_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`specialty_id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specialties`
--

LOCK TABLES `specialties` WRITE;
/*!40000 ALTER TABLE `specialties` DISABLE KEYS */;
INSERT INTO `specialties` VALUES (1,'Кардіологія','Спеціалізація на захворюваннях серця та судин.'),(2,'Дерматологія','Спеціалізація на шкірних захворюваннях.'),(3,'Терапія','Загальна медична практика.'),(4,'Офтальмологія','Спеціалізація на захворюваннях очей.'),(5,'Неврологія','Спеціалізація на нервовій системі.');
/*!40000 ALTER TABLE `specialties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statuses`
--

DROP TABLE IF EXISTS `statuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `statuses` (
  `status_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`status_id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statuses`
--

LOCK TABLES `statuses` WRITE;
/*!40000 ALTER TABLE `statuses` DISABLE KEYS */;
INSERT INTO `statuses` VALUES (1,'Запланований','Прийом заплановано та підтверджено.'),(2,'Відбувся','Прийом відбувся, діагноз поставлено.'),(3,'Відмінений','Прийом скасовано пацієнтом чи лікарем.'),(4,'Пропущений','Пацієнт не з’явився на прийом.');
/*!40000 ALTER TABLE `statuses` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-01-17 12:22:38
