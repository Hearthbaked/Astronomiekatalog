create database astronomiekatalog;
use astronomiekatalog;

create table galaxie
(idGalaxie int primary key auto_increment not null, galaxie_anzahl_sterne int,
 galaxie_name varchar(50), galaxie_typ varchar(50), galaktischer_kern_schwarzes_loch varchar(50),
 galaxie_alter float, galaxie_absolute_helligkeit float, galaxie_durchmesser float,
 masse_inkl_dunkle_materie float, galaxie_geschwindigkeit float,
 galaxie_dicke float);

create table sternsystem
(idSternsystem int primary key auto_increment not null, 
 idGalaxie int, foreign key (idGalaxie) references galaxie (idGalaxie),
 anzahl_sterne int, spektralklasse varchar(50), sternsystem_typ varchar(50), 
 sternsystem_name varchar(50), sternsystem_stern varchar(100),
 asteroidenfelder varchar(100), sternsystem_alter float, sternsystem_absolute_helligkeit float,
 sternsystem_masse float);

create table planet
(idPlanet int primary key auto_increment not null, idSternsystem int,
 foreign key (idSternsystem) references sternsystem(idSternsystem),
 anzahl_monde_satelliten int, planet_name varchar(50), planet_typ varchar(50), 
 umlauf_tage float, planet_masse float, planet_durchmesser float,
 periphel_aphel float, planet_druck float, planet_temperatur float);
 