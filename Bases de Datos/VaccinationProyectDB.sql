CREATE DATABASE VaccinationProjectDB;
USE VaccinationProjectDB;
SET LANGUAGE us_english;

-- Creacion de Tablas

CREATE TABLE MANAGER(
	Id INT PRIMARY KEY,
	EmployeeName VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	HomeAddress VARCHAR(50) NOT NULL,
	Id_TypeEmployee INT NOT NULL,
	UserName VARCHAR(25) NOT NULL,
	Pass VARCHAR(25) NOT NULL
);

CREATE TABLE BOOTH(
	Id INT PRIMARY KEY,
	Place VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(50) NOT NULL,
	ManagerBooth VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL
);

CREATE TABLE CITIZEN(
	Dui VARCHAR(10) PRIMARY KEY,
	CitizenName VARCHAR(75) NOT NULL,
	CitizenAddress VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(50) NOT NULL,
	Email VARCHAR(50),
	NumIdentifier INT,
	Id_PriorityGroup INT NOT NULL,
	Id_Manager INT NOT NULL
);

CREATE TABLE RESERVATION (
	Id INT PRIMARY KEY IDENTITY,
	DateReservation DATETIME NOT NULL,
	VaccinationPlace VARCHAR(50) NOT NULL,
	Dui_Citizen VARCHAR(10) NOT NULL
);

CREATE TABLE VACCINATION_PROCESS(
	Id INT PRIMARY KEY IDENTITY,
	Time_SideEffects INT,
	Id_SideEffects INT,
	DatewWaitingQueue DATETIME NOT NULL,
	DateVaccination DATETIME NOT NULL,
	Date_SecondDose DATETIME,
	Place_SecondDose VARCHAR(50),
	Id_Reservation INT NOT NULL
);

CREATE TABLE REGISTER(
	Id INT PRIMARY KEY IDENTITY,
	Id_Manager INT NOT NULL,
	Id_Booth INT NOT NULL,
	DateLogin DATETIME NOT NULL,
);

CREATE TABLE TYPE_EMPLOYEE(
	Id INT PRIMARY KEY,
	TypeEmployee VARCHAR(25) NOT NULL
);

CREATE TABLE PRIORITY_GROUP(
	Id INT PRIMARY KEY,
	PriorityGroup VARCHAR(75) NOT NULL
);

CREATE TABLE CHRONIC_DISEASE(
	Id INT PRIMARY KEY IDENTITY,
	ChronicDisease VARCHAR(50),
	Dui_Citizen VARCHAR(10) NOT NULL
);

CREATE TABLE SIDE_EFFECTS(
	Id INT PRIMARY KEY,
	SideEffect VARCHAR(50),
);

-- Primary/Foreign Key section
-- TYPE_EMPLOYEE -> MANAGER
ALTER TABLE MANAGER ADD FOREIGN KEY (Id_TypeEmployee) REFERENCES TYPE_EMPLOYEE(Id)
-- MANAGER -> REGISTER
ALTER TABLE REGISTER ADD FOREIGN KEY (Id_Manager) REFERENCES MANAGER(Id)
-- BOOTH -> REGISTER
ALTER TABLE REGISTER ADD FOREIGN KEY (Id_Booth) REFERENCES BOOTH(Id)
-- PRIORITY_GROUP -> CITIZEN
ALTER TABLE CITIZEN ADD FOREIGN KEY (Id_PriorityGroup) REFERENCES PRIORITY_GROUP(Id)
-- MANAGER -> CITIZEN
ALTER TABLE CITIZEN ADD FOREIGN KEY (Id_Manager) REFERENCES MANAGER(Id)
-- CITIZEN -> CHRONIC_DISEASE
ALTER TABLE CHRONIC_DISEASE ADD FOREIGN KEY (Dui_Citizen) REFERENCES CITIZEN(Dui)
-- CITIZEN -> RESERVATION
ALTER TABLE RESERVATION ADD FOREIGN KEY (Dui_Citizen) REFERENCES CITIZEN(Dui)
-- SIDE_EFFECTS -> VACCINATION_PROCESS
ALTER TABLE VACCINATION_PROCESS ADD FOREIGN KEY (Id_SideEffects) REFERENCES SIDE_EFFECTS(Id)
-- RESERVATION -> VACINATION_PROCESS
ALTER TABLE VACCINATION_PROCESS ADD FOREIGN kEY (Id_Reservation) REFERENCES RESERVATION(Id)

-- Initial DataBank

INSERT INTO TYPE_EMPLOYEE VALUES(1,'Pasante')
INSERT INTO TYPE_EMPLOYEE VALUES(2,'Medio tiempo')
INSERT INTO TYPE_EMPLOYEE VALUES(3,'Tiempo Completo')

INSERT INTO MANAGER VALUES(1,'Ariadna Minguez Pleitez','AriMiP@isss.gob.sv','Bo Distrito Cc Cl Arce Edif Rubén Darío No L-1',1,'AriadPleitez','FKUtsj')
INSERT INTO MANAGER VALUES(2,'Melchor Llorente Berrocal','MeLoCal@isss.gob.sv','Blvd Merliot Lt 7 Z Comercial Edif Adebien Ii',3,'MelRocal','AWucTU')
INSERT INTO MANAGER VALUES(3,'Matias Serna Magan','MaNaGan@isss.gob.sv','Urb Sta Elena Resid Casa Linda Políg A Sda I No 22',2,'MatGan','EwsGVh')
INSERT INTO MANAGER VALUES(4,'Sebastian Caranza Bravo','SebZaBravo@isss.gob.sv','Col Libertad Av Don Bosco Edif Ex-Ivu',2,'SebBravo','nPSdBP')
INSERT INTO MANAGER VALUES(5,'Daniel Espino Santana','DanSantana@isss.gob.sv','Colonia Miramonte Cl Colima Políg Q No 23',3,'EspSantana','cRhvSy')
INSERT INTO MANAGER VALUES(6,'Bruno Zepelli Buccariati','BrunoZep@isss.gob.sv','Km. 12 3/4 Autopista A Comalapa',3,'ZepelliBuc','xSkcTG')
INSERT INTO MANAGER VALUES(7,'Erina Winterfall','EriWinter@isss.gob.sv','Col La Sultana Ii Av Cumbres De Cuscatlán',1,'EriTerfall','QepUYg')
INSERT INTO MANAGER VALUES(8,'Josue Portillo Yrion','JosPorYrion@isss.gob.sv','Blvd del Ejérc Nac Km 5 1/2 Colonia Las Brisas',2,'JosYrion','RzguML')
INSERT INTO MANAGER VALUES(9,'Adriana Chacon Arterias','AdriCArterias@isss.gob.sv','Col San Benito Cl La Reforma No 227',3,'AdriArterias','ghkTjN')
INSERT INTO MANAGER VALUES(10,'Asier Samper Vargas','AsiSaV@isss.gob.sv','Blvd Los Héroes Cond Los Héroes Loc 8-G Nvl 8',3,'AsiVargas','ATKmaN')

INSERT INTO BOOTH VALUES(1,'2 Avenida Norte, Santa Tecla','1343-0836','Matias Magan','CabinaNorteSantaTecla@gob.sv')
INSERT INTO BOOTH VALUES(2,'Comunidad 13 De Enero San Salvador, Mejicanos','4041-6519','Asier Vargas','CabinaMejicanos@gob.sv')
INSERT INTO BOOTH VALUES(3,'4 Calle Oriente #2-3, Lourdes','1555-6702','Melchor Berrocal','CabinaLourdes@gob.sv')
INSERT INTO BOOTH VALUES(4,'6 Calle Poniente Nº4-4, Santa Tecla','8435-5708','Ariadna Pleitez','CabinaSantaTecla@gob.sv')
INSERT INTO BOOTH VALUES(5,'C. a Planes de Renderos 8 1/2,Planes de Renderos','9256-6507','Erina Winterfall','CabinaRenderos@gob.sv')
INSERT INTO BOOTH VALUES(6,'Avenida Jerusalen, San Salvador','6915-0706','Bruno Buccariati','CabinaJerusalen@gob.sv')
INSERT INTO BOOTH VALUES(7,'Comunidad 13 De Enero San Salvador, Mejicanos','8761-6041','Josue Yrion','Cabina13Enero@gib.sv')
INSERT INTO BOOTH VALUES(8,'Bulevar De Los Heroes, San Salvador','2241-2669','Daniel Santana','CabinaLosHeroes@gob.sv')
INSERT INTO BOOTH VALUES(9,'San Salvador','2070-2761','Adriana Arterias','CabinaSanSalvador@gob.sv')
INSERT INTO BOOTH VALUES(10,'Parque Pancho Lara, Pje San Jose, San Salvador','4711-0745','Sebastian Bravo','CabinaSanJose@gob.sv')

INSERT INTO PRIORITY_GROUP VALUES(1,'Mayor de 60 años')
INSERT INTO PRIORITY_GROUP VALUES(2,'Personal de Salud')
INSERT INTO PRIORITY_GROUP VALUES(3,'Encargado de Seguridad Nacional')
INSERT INTO PRIORITY_GROUP VALUES(4,'Mayor de edad con enfermadad no transmisible')
INSERT INTO PRIORITY_GROUP VALUES(5,'Personal de Gobierno central')

INSERT INTO SIDE_EFFECTS VALUES(1,'Dolor y/o sensibilidad en el lugar de inyeccion')
INSERT INTO SIDE_EFFECTS VALUES(2,'Enrojecimiento en el lugar de inyeccion')
INSERT INTO SIDE_EFFECTS VALUES(3,'Dolor de cabeza')
INSERT INTO SIDE_EFFECTS VALUES(4,'Fiebre')
INSERT INTO SIDE_EFFECTS VALUES(5,'Mialgia')
INSERT INTO SIDE_EFFECTS VALUES(6,'Artralgia')
INSERT INTO SIDE_EFFECTS VALUES(7,'Anafilaxia')
INSERT INTO SIDE_EFFECTS VALUES(8,'Fatiga')
INSERT INTO SIDE_EFFECTS VALUES(9, 'Otros')