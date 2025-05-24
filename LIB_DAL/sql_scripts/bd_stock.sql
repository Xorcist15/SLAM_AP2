CREATE TABLE fabricant (
   fab_id VARCHAR(10) NOT NULL,
   fab_nom VARCHAR(50),
   PRIMARY KEY (fab_id)
);

CREATE TABLE categorie (
   cat_code VARCHAR(5) NOT NULL,
   cat_libelle VARCHAR(50),
   PRIMARY KEY (cat_code)
);

CREATE TABLE unite (
   unit_code VARCHAR(3) NOT NULL,
   unit_libelle VARCHAR(30),
   PRIMARY KEY (unit_code)
);

CREATE TABLE pays (
   pays_nom VARCHAR(50) NOT NULL,
   PRIMARY KEY (pays_nom)
);

CREATE TABLE type (
   type_id VARCHAR(3) NOT NULL,
   type_description VARCHAR(50),
   PRIMARY KEY (type_id)
);

CREATE TABLE article (
   article_ref VARCHAR(20) NOT NULL,
   article_libelle VARCHAR(120),
   unit_code VARCHAR(3) NOT NULL,
   cat_code VARCHAR(5) NOT NULL,
   fab_id VARCHAR(10) NOT NULL,
   PRIMARY KEY (article_ref),
   FOREIGN KEY (unit_code) REFERENCES unite (unit_code),
   FOREIGN KEY (cat_code) REFERENCES categorie (cat_code),
   FOREIGN KEY (fab_id) REFERENCES fabricant (fab_id)
);

CREATE TABLE ville (
   ville_nom VARCHAR(50) NOT NULL,
   pays_nom VARCHAR(50) NOT NULL,
   PRIMARY KEY (ville_nom, pays_nom),
   FOREIGN KEY (pays_nom) REFERENCES pays (pays_nom)
);

CREATE TABLE depot (
   depot_num INT NOT NULL,
   depot_nom VARCHAR(50),
   depot_superficie DECIMAL(15, 2),
   depot_lat DECIMAL(9, 6),
   depot_long DECIMAL(9, 6),
   ville_nom VARCHAR(50) NOT NULL,
   pays_nom VARCHAR(50) NOT NULL,
   PRIMARY KEY (depot_num),
   FOREIGN KEY (ville_nom, pays_nom) REFERENCES ville (ville_nom, pays_nom)
);

CREATE TABLE mvt_stock (
   mvt_id INT IDENTITY(1,1) NOT NULL, 
   mvt_date_heure DATETIME NOT NULL,
   mvt_qte DECIMAL(15, 2),
   type_id VARCHAR(3) NOT NULL,
   article_ref VARCHAR(20) NOT NULL,
   depot_num INT NOT NULL,
   PRIMARY KEY (mvt_id),
   FOREIGN KEY (type_id) REFERENCES type (type_id),
   FOREIGN KEY (article_ref) REFERENCES article (article_ref),
   FOREIGN KEY (depot_num) REFERENCES depot (depot_num)
);

CREATE TABLE inventaire (
   depot_num INT NOT NULL,
   article_ref VARCHAR(20) NOT NULL,
   inv_qte DECIMAL(15, 2) DEFAULT 0,
   PRIMARY KEY (depot_num, article_ref),
   FOREIGN KEY (depot_num) REFERENCES depot (depot_num),
   FOREIGN KEY (article_ref) REFERENCES article (article_ref)
);