-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `TriviaAD2016` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `TriviaAD2016` ;

-- -----------------------------------------------------
-- Table `mydb`.`Libros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Libros` (
  `idLibro` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `Genero` VARCHAR(45) NOT NULL,
  `Autor` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idLibro`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Preguntas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Preguntas` (
  `idPreguntas` INT NOT NULL AUTO_INCREMENT,
  `Utilizada` TINYINT(1) NOT NULL,
  `Combo` CHAR(1) NOT NULL,
  `Respuesta` TEXT NOT NULL,
  `Pregunta` TEXT NOT NULL,
  `Libros_idLibros` INT NOT NULL,
  PRIMARY KEY (`idPreguntas`),
  INDEX `fk_Preguntas_Libros_idx` (`Libros_idLibros` ASC),
  CONSTRAINT `fk_Preguntas_Libros`
    FOREIGN KEY (`Libros_idLibros`)
    REFERENCES `triviaAD2016`.`Libros` (`idLibro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Final`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Final` (
  `idFinal` INT NOT NULL AUTO_INCREMENT,
  `Utilizada` TINYINT(1) NOT NULL,
  `Pregunta` TEXT NOT NULL,
  `Respuesta` TEXT NOT NULL,
  `Libros_idLibro` INT NOT NULL,
  PRIMARY KEY (`idFinal`),
  INDEX `fk_Final_Libros1_idx` (`Libros_idLibro` ASC),
  CONSTRAINT `fk_Final_Libros1`
    FOREIGN KEY (`Libros_idLibro`)
    REFERENCES `triviaAD2016`.`Libros` (`idLibro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Equipos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Equipos` (
  `Id_equipo` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(40) NOT NULL,
  `ScoreFinal` INT NOT NULL,
  `NoParticipantes` INT NOT NULL,
  PRIMARY KEY (`Id_equipo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Participantes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Participantes` (
  `id_participante` INT NOT NULL,
  `id_equipo` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `LibroDeseado` VARCHAR(45),
  PRIMARY KEY (`id_participante`, `id_equipo`),
  INDEX `fk_Participantes_Equipos1_idx` (`id_equipo` ASC),
  CONSTRAINT `fk_Participantes_Equipos1`
    FOREIGN KEY (`id_equipo`)
    REFERENCES `triviaAD2016`.`Equipos` (`Id_equipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Trivias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Trivias` (
  `idTrivias` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `fecha` DATE NOT NULL,
  PRIMARY KEY (`idTrivias`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Libros_Trivias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Libros_Trivias` (
  `Libros_idLibro` INT NOT NULL,
  `Trivias_idTrivias` INT NOT NULL,
  `combo` CHAR(1) NOT NULL,
  PRIMARY KEY (`Libros_idLibro`, `Trivias_idTrivias`),
  INDEX `fk_Libros_has_Trivias_Trivias1_idx` (`Trivias_idTrivias` ASC),
  INDEX `fk_Libros_has_Trivias_Libros1_idx` (`Libros_idLibro` ASC),
  CONSTRAINT `fk_Libros_has_Trivias_Libros1`
    FOREIGN KEY (`Libros_idLibro`)
    REFERENCES `triviaAD2016`.`Libros` (`idLibro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libros_has_Trivias_Trivias1`
    FOREIGN KEY (`Trivias_idTrivias`)
    REFERENCES `triviaAD2016`.`Trivias` (`idTrivias`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Equipos_Trivias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `triviaAD2016`.`Equipos_Trivias` (
  `Equipos_Id_equipo` INT NOT NULL,
  `Trivias_idTrivias` INT NOT NULL,
  PRIMARY KEY (`Equipos_Id_equipo`, `Trivias_idTrivias`),
  INDEX `fk_Equipos_has_Trivias_Trivias1_idx` (`Trivias_idTrivias` ASC),
  INDEX `fk_Equipos_has_Trivias_Equipos1_idx` (`Equipos_Id_equipo` ASC),
  CONSTRAINT `fk_Equipos_has_Trivias_Equipos1`
    FOREIGN KEY (`Equipos_Id_equipo`)
    REFERENCES `triviaAD2016`.`Equipos` (`Id_equipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Equipos_has_Trivias_Trivias1`
    FOREIGN KEY (`Trivias_idTrivias`)
    REFERENCES `triviaAD2016`.`Trivias` (`idTrivias`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
