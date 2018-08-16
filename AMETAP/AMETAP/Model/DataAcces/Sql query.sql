//Creer table Personnel

Create table Personnel
(
    matricule int primary key ,
    nom varchar(50) ,
    prenom varchar(50) ,
    id_NATURAGENT int ,	
    Code_Fonc int ,	
    PERS_CET int ,
    sex varchar(2) ,	
    Etat_civil varchar(2) ,	
    nbr_enfant int ,	
    Date_naissaince date ,	
    Lieu varchar(20) ,	
    Cin varchar(15) unique ,	
    Adresse varchar (80) ,
    Tel varchar(10) ,	
    Date_recrutement date ,	
    PERS_CATPERS int ,	
    PERS_AFFECT varchar(5) ,
    Occupation varchar(30) ,	
    Code_banque int	,
    Code_agence int ,	
    Numero_compte int ,	
    Email varchar(30) 
);     

Creer table Nature Agent
Create table Nature_Agent
(
    id_NATURAGENT int primary key ,
    nombre int ,
    description varchar(30) 
);

Modifier les attribut

ALTER TABLE Personnel
ADD FOREIGN KEY (id_NATURAGENT)
REFERENCES Nature_Agent(id_NATURAGENT)


Insérer nature Agent

insert into Nature_Agent values(1 ,15,' DETACHE AUPRES DE L ETAP & PAYE PAR ETAP ');
insert into Nature_Agent values(2	,20,	'PRE_EMBAUCHE');
insert into Nature_Agent values(3,	2	,'CONTRACTUEL EXERCANT A ETAP');
insert into Nature_Agent values(4,	1	,'TITULAIRE EXERCANT A ETAP');
insert into Nature_Agent values(5,	3	,'CONTRACTUEL AILLEURS');
insert into Nature_Agent values(6	,5,	'DETACHE AUPRES D ETAP');
insert into Nature_Agent values(7	,6,	'DETACHE ET PAYE PAR ETAP');
insert into Nature_Agent values(8	,7,	'DETACHE,PAYE PAR ETAP ET FACTURE');
insert into Nature_Agent values(9	,8,	'DETACHE NON PAYE PAR ETAP');
insert into Nature_Agent values(10	,9,	'S.I.V.P');
insert into Nature_Agent values(11	,10,	'FORMATION EMPLOI');
insert into Nature_Agent values(12	,11,	'STAGIAIRE ECOLE');
insert into Nature_Agent values(13	,12,	'SITUATION INTERRUPTION DE TRAVAIL');
insert into Nature_Agent values(14	,13,	'PARTANT')
insert into Nature_Agent values(15	,14,	'DISPONIBILITE')


Create table admin
       (
           matricule int primary key ,
           login varchar(50) unique ,
           password varchar(650)
      );

ALTER TABLE admin
ADD FOREIGN KEY (matricule)
REFERENCES Personnel(matricule)

insert into Personnel values (1,'Habib','Aroua',3,104,100,'M','M',0,'15/11/1994','Tunis','07472328','10 rue mosaique Ariaan','26053091','06/02/2017',0,'Oui','Ingénieur',100,404,133,'Habib.aroua@hotmail.fr');
insert into Personnel values (2,'Sonia','Borgi',3,104,100,'F','C',0,'02/10/1964','Tunis','2570012','20 rue Star Manzah 5 Ariana','55036987','29/05/1996',0,'Oui','Technicien',100,404,133,'Sonia.Borgi@gmail.com');
insert into Personnel values (3,'Haykel','Gorgi',3,100,100,'M','M',4,'15/11/1994','Tunis','02579','10 Global Bardo','20915630','06/02/2017',0,'Oui','Ingénieur',100,404,133,'Haykel.gorgi@hotmail.com');
insert into Personnel values (4,'Safa','Elmiri',3,104,100,'F','C',0,'20/05/1994','Tunis','07198216','10 rue mosaique Ariaan','26053091','06/02/2017',0,'Oui','Ingénieur',100,404,133,'Habib.aroua@hotmail.fr');
insert into Personnel values (5,'Hatem','Louhichi',3,104,100,'M','M',0,'15/3/1975','Sousse','025746','5 rue Chine Sousse','20336887','06/02/2017',0,'Oui','Ingénieur',100,404,133,'Louhichi.hatem@hotmail.com');
insert into Personnel values (6,'Saida','Ben Ali',6,104,100,'F','C',0,'7/4/1980','Mahdia','023587','Cité nassir Ariana','25789','06/04/2010',0,'Oui','Laboratoire',100,404,133,'Saida.BenAli@hotmail.fr');
insert into Personnel values (7,'Samar','Nabli',2,205,99,'F','M',2,'02/03/1986','Ben Arous','0587967','Avenue tayeb mhiri Tunis','3665','06/04/2009',0,'Non','Femme de ménage',100,404,133,'');
insert into Personnel values (8,'Hmaied','Naouel',3,205,99,'F','C',0,'02/03/1986','Ariana','0520058','Borj louzir Ariana','2005','06/04/2016',0,'Non','Technicien supérier',100,404,133,'Naouel.hmaied@hotmail.fr');
insert into Personnel values (9,'Naoufel','Majdoubi',1,205,99,'M','M',0,'02/03/1970','Bizerte','2569','Rue bassatin Zarzouna','2569','06/04/1992',0,'Non','Technicien supérier',100,404,133,'majdoubi.naoufel@yahoo.es');
insert into Personnel values (11,'Samir','Borgi',5,21,20,'M','M',2,'02/07/1960','Tunis','235','Avenue liberté Menzah 5','2569','07/04/1988',0,'Oui','Médcin',100,404,133,'');
insert into Personnel values (12,'Chtourou','Sabiha',1,210,20,'M','F',4,'02/06/1965','Sfax','214','Avenue Tayeb Mhiri Sfax','2147','15/11/1987',0,'Oui','Formateur',100,404,133,'');
insert into Personnel values (13,'Kedidi','Sadok',2,104,108,'F','C',0,'02/10/1978','Ariana','2570014','rue tayeb mfiri Ariana','55036987','29/05/1999',0,'Oui','Ingenieur',100,404,133,'')
insert into Personnel values (15,'Miri','Maroua',1,104,108,'F','C',0,'28/03/1987','Ariana','2570014','cite ghazela Ariana','55036987','29/05/2008',0,'Oui','resource humain',100,404,133,'')
insert into Personnel values (14,'Hmaied','Sara',5,104,108,'F','C',0,'02/10/1990','Ariana','2570013','cite ghazela Ariana','55036987','29/05/',0,'Oui','Ingenieur',100,404,133,'')
insert into Personnel values (16,'Brinsi','Anis',5,104,108,'M','C',0,'02/10/1985','Ariana','25060013','cite ghazela Ariana','55036987','29/05/2007',0,'Oui','Ingenieur',100,404,134,'')
insert into Personnel values (21,'Ben Salah','Salah',3,104,108,'M','C',0,'17/11/1970','Morneg','014789','Dokeli Morneg','71715961','29/05/1988',0,'Oui','Bilologi',100,404,134,'')
insert into Personnel values (20,'Mansouri','Salah',2,104,108,'M','C',0,'17/11/1970','Morneg','250500003','Dokeli Morneg','550000087','29/05/1988',0,'Oui','Bilologi',100,404,134,'')
insert into Personnel values (19,'Miri','Hamda',2,104,108,'M','M',2,'02/10/1962','Morneg','25050003','Dokeli Morneg','55041987','29/05/1988',0,'Oui','Bilologi',100,404,134,'')
insert into Personnel values (18,'Chalouf','Ibticem',1,104,108,'F','M',2,'02/10/1962','Morneg','25050013','Dokeli Morneg','55041987','29/05/2007',0,'Oui','Ingenieur',100,404,134,'')


Create table Club 
(
    id int primary key ,
    description varchar(200)
);

Create table Organisateur
(
    id int primary key ,
    nom_organisateur varchar(50) ,
    email varchar(50) ,
    adresse varchar(50)
);


ALTER TABLE Club
ADD FOREIGN KEY (id)
REFERENCES Organisateur(id) ;


Create table Agence_Voyage
(
    id int primary key ,
    description varchar(200)
);

ALTER TABLE Agence_Voyage
ADD FOREIGN KEY (id)
REFERENCES Organisateur(id) ;

Create table Centre
(
    id int primary key ,
    description varchar(200)
);

ALTER TABLE Centre
ADD FOREIGN KEY (id)
REFERENCES Organisateur(id) ;



Create table participant 
( 
    matricule int primary key ,
    date_insc date
);

Create table adherent 
(
    matricule int primary key ,
    login varchar(100) unique ,
    password varchar(800)
);

ALTER TABLE adherent
ADD FOREIGN KEY (matricule)
REFERENCES Personnel(matricule);

ALTER TABLE adherent
ADD FOREIGN KEY (matricule)
REFERENCES Participant(matricule);

ALTER TABLE adherent
ADD FOREIGN KEY (matricule)
REFERENCES Personnel(matricule);

Create table participant 
( 
    matricule int primary key ,
    date_insc date
);

Create table adherent 
(
    matriculeEtap int primary key ,
    matriculeAmetap int unique ,
    login varchar(100) unique ,
    password varchar(800)
);

ALTER TABLE adherent
ADD FOREIGN KEY (matriculeEtap)
REFERENCES Personnel(matricule);
drop table adherent ;
drop table participant 

ALTER TABLE adherent
ADD FOREIGN KEY (matriculeAmetap)
REFERENCES Participant(matricule);
insert into adherent values(9,'Haboub','azerty');
insert into participant values(9,'16/03/2017');
select * from personnel ;





Table Conjoint:
Create table Conjoint 
(
    Cin int primary key ,
    Nom varchar(200)  not null,
    Prenom varchar(200)  not null,
    Date_naissance date  not null,
    metier varchar(200) ,
    matricule int 
);

ALTER TABLE Conjoint
ADD FOREIGN KEY (matricule)
REFERENCES adherent(matriculeAmetap);

Table Enfant :
Create table Enfant
(
    id int primary key ,
    Nom varchar(200)  not null,
    Prenom varchar(200)  not null,
    Date_naissance date  not null,
    ecole varchar(200) ,
    matricule int 
);

ALTER TABLE Enfant
ADD FOREIGN KEY (matricule)
REFERENCES adherent(matriculeAmetap);

ALTER TABLE Enfant
ADD FOREIGN KEY (id)
REFERENCES Participant(matricule);

ALTER TABLE Conjoint
ADD FOREIGN KEY (cin)
REFERENCES Participant(matricule);

Table Budget:
Create table Budget
(
    id int primary key ,
    annee int unique ,
    montant_provisoire int ,
    montant_final int
);

Create table Type_Activite
(
    id int primary key ,
    libelle varchar(100) unique 
);
insert into Type_Activite values(1,'Activite culturel');
insert into Type_Activite values(2,'Activite de loisir');

create table Activite
( 
    id int primary key ,
    Nom_Activite varchar(200) ,
    Capacite int ,
    Nombre_participant int ,
    Date_debut date ,
    Date_fin date ,
    CONSTRAINT check_Date_Fin CHECK (Date_fin > Date_debut) ,
    prix_uinitaire int ,
    montant_prevu int ,
    montant_actuel int ,
    id_TypeActivite int ,
    idBudget int ,
    idOrganisateur int
);

ALTER TABLE Activite
ADD FOREIGN KEY (id_TypeActivite)
REFERENCES Type_Activite(id);

ALTER TABLE Activite
ADD FOREIGN KEY (idBudget)
REFERENCES Budget(id);

