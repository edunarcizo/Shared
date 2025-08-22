-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: projeto
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `itenspedido`
--

DROP TABLE IF EXISTS `itenspedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `itenspedido` (
  `codigoProduto` int(11) NOT NULL,
  `codigoPedido` int(11) NOT NULL,
  `quantidadeDoProduto` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigoPedido`,`codigoProduto`),
  KEY `fk_produto` (`codigoProduto`),
  CONSTRAINT `fk_pedido` FOREIGN KEY (`codigoPedido`) REFERENCES `pedido` (`codigoPedido`),
  CONSTRAINT `fk_produto` FOREIGN KEY (`codigoProduto`) REFERENCES `produto` (`codigoProduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itenspedido`
--

LOCK TABLES `itenspedido` WRITE;
/*!40000 ALTER TABLE `itenspedido` DISABLE KEYS */;
INSERT INTO `itenspedido` VALUES (1,3,1),(1,5,1),(1,10,2),(1,11,3),(1,12,12),(1,13,12),(1,14,1),(1,18,4),(1,19,3),(1,21,3),(1,23,3),(1,25,3),(1,27,3),(1,30,3),(1,32,3),(1,34,3),(1,35,3),(1,36,3),(1,37,37),(1,38,37),(1,39,37),(1,40,37),(1,43,37),(1,44,30),(1,45,2),(1,46,10),(1,47,10),(1,48,10),(1,50,2),(1,51,2),(1,52,2),(1,53,2),(1,54,2),(1,56,3),(1,58,3),(1,60,24),(1,67,4),(1,68,3),(1,69,3),(1,70,3),(1,72,3);
/*!40000 ALTER TABLE `itenspedido` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-08-22 17:51:14
