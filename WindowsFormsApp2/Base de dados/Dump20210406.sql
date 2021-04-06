-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mercearia
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `cliente_cod` varchar(20) NOT NULL,
  `cliente_nome` varchar(20) DEFAULT NULL,
  `cliente_apelido` varchar(20) DEFAULT NULL,
  `cliente_bi` varchar(20) DEFAULT NULL,
  `cliente_telef` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`cliente_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra` (
  `compra_cod` varchar(20) NOT NULL,
  `compra_quant` int DEFAULT NULL,
  `compra_data` timestamp(6) NULL DEFAULT NULL,
  `compra_valor_recebido` float DEFAULT NULL,
  PRIMARY KEY (`compra_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faz_compra`
--

DROP TABLE IF EXISTS `faz_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `faz_compra` (
  `cod_prod` varchar(20) NOT NULL,
  `cod_cliente` varchar(20) NOT NULL,
  `cod_compra` varchar(20) NOT NULL,
  PRIMARY KEY (`cod_prod`,`cod_cliente`,`cod_compra`),
  KEY `fk_compra_cod` (`cod_compra`),
  KEY `fk_cliente_cod` (`cod_cliente`),
  CONSTRAINT `fk_cliente_cod` FOREIGN KEY (`cod_cliente`) REFERENCES `cliente` (`cliente_cod`),
  CONSTRAINT `fk_compra_cod` FOREIGN KEY (`cod_compra`) REFERENCES `compra` (`compra_cod`),
  CONSTRAINT `fk_prod_cod` FOREIGN KEY (`cod_prod`) REFERENCES `produto` (`prod_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faz_compra`
--

LOCK TABLES `faz_compra` WRITE;
/*!40000 ALTER TABLE `faz_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `faz_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `prod_cod` varchar(20) NOT NULL,
  `prod_nome` varchar(30) DEFAULT NULL,
  `prod_descricao` varchar(50) DEFAULT NULL,
  `prod_marca` varchar(30) DEFAULT NULL,
  `prod_preco` float NOT NULL,
  PRIMARY KEY (`prod_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES ('A001','Feijao','Feijao Manteiga sul africana','Manteiga',120),('A002','Refrigerante','Refrigerante da Coca-cola','Sprite',80),('A003','Arroz','Arroz 25kg produto da Tailandia','Mariana',1200);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-06 14:21:23
