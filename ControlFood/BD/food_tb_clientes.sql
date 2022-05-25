-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: food
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `tb_clientes`
--

DROP TABLE IF EXISTS `tb_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_clientes` (
  `codCli` int NOT NULL AUTO_INCREMENT,
  `nomeCli` varchar(100) DEFAULT NULL,
  `cpfCli` varchar(14) DEFAULT NULL,
  `telCli` varchar(14) DEFAULT NULL,
  `enderecoCli` varchar(50) DEFAULT NULL,
  `numCli` int DEFAULT NULL,
  `bairroCli` varchar(50) DEFAULT NULL,
  `cidadeCli` varchar(50) DEFAULT NULL,
  `ufCli` varchar(2) DEFAULT NULL,
  `cepCli` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`codCli`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_clientes`
--

LOCK TABLES `tb_clientes` WRITE;
/*!40000 ALTER TABLE `tb_clientes` DISABLE KEYS */;
INSERT INTO `tb_clientes` VALUES (1,'Wagner Ramos Toth','123.456.789-01','(13)99123-4567','Rua Yoshio Takaki',240,'Jd. Caiçara II','Registro','SP','11900-000'),(3,'Cleonice Marcondes','456.123.789-21','(13)99456-7890','Rua Yoshio Takaki',240,'Jd. Caiçara II','Registro','SP','11900-000'),(5,'João Victor M Toth','456.123.987-56','(13)99874-2312','Rua Yoshio Takaki',240,'Jd. Caicara II','Registro','SP','11900-000'),(8,'Gustavo Marcondes Toth','987.654.123-20','(13)99765-8796','Rua Yoshio Takaki',240,'Jd. Caiçara II','Registro','SP','11900-000'),(15,'Tone Stark','987.546.321-01','987.546.321-01','Av. Ultimato',888,'Jd. Vingadores','Registro','SP','11.900-000');
/*!40000 ALTER TABLE `tb_clientes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-25  9:54:13
