use zoo;
drop table animals;
create table animals (ANIMAL_ID VARCHAR(45), ANIMAL_NAME VARCHAR(45), SPEICES VARCHAR(45), ANIMAL_BREED VARCHAR(45), COUNTRY_OF_ORIGIN VARCHAR(45), AGE INT, GENDER ENUM('Male','Female'), COLOUR VARCHAR(45), HEIGHT INT, WEIGHT INT, DIET VARCHAR (45), HABITAT VARCHAR(45), 
PRIMARY KEY (ANIMAL_ID));
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A0001', 'Ned', 'Owl', 'Bird', 'Canade', '22', 'Male', 'White', '112', '45');
SELECT * FROM animals;
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A002', 'Pinky', 'Flamigo', 'Bird', 'Chile', '6', 'Female', 'Pink', '122', '88');
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A003', 'Ryan', 'Ryano', 'Mammal', 'Africa', '24', 'Male', 'Grey', '1112', '445');
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A011', 'Fred', 'Ostrich', 'Bird', 'Africa', '12', 'Male', 'Black', '112', '45');
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A101', 'Betty', 'Lizard', 'Reptile', 'America', '2', 'Female', 'Blue', '12', '5');
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A201', 'Bill', 'Elephant', 'Mammal', 'Africa', '22', 'Male', 'Grey', '1112', '45');
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A021', 'Perry', 'Eagle', 'Bird', 'Canade', '22', 'Male', 'White', '112', '45');
INSERT INTO `zoo`.`animals` (`ANIMAL_ID`, `ANIMAL_NAME`, `SPEICES`, `ANIMAL_BREED`, `COUNTRY_OF_ORIGIN`, `AGE`, `GENDER`, `COLOUR`, `HEIGHT`, `WEIGHT`) VALUES ('A221', 'Earl', 'Swan', 'Bird', 'Canade', '22', 'Male', 'White', '112', '45');
select * from animals;