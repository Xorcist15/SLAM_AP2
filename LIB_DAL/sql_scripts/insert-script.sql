-- Insert into pays
INSERT INTO pays (pays_nom) VALUES 
('France'),
('Germany'),
('USA'),
('Japan');

-- Insert into ville
INSERT INTO ville (ville_nom, pays_nom) VALUES 
('Paris', 'France'),
('Berlin', 'Germany'),
('New York', 'USA'),
('Tokyo', 'Japan');

-- Insert into fabricant
INSERT INTO fabricant (fab_id, fab_nom) VALUES 
('FAB001', 'Fabricant A'),
('FAB002', 'Fabricant B'),
('FAB003', 'Fabricant C');

-- Insert into categorie
INSERT INTO categorie (cat_code, cat_libelle) VALUES 
('CAT01', 'Electronics'),
('CAT02', 'Furniture'),
('CAT03', 'Clothing');

-- Insert into unite
INSERT INTO unite (unit_code, unit_libelle) VALUES 
('KG', 'Kilogram'),
('L', 'Liter'),
('PCS', 'Pieces');

-- Insert into type
INSERT INTO type (type_id, type_description) VALUES 
('INV', 'Inventaire'),
('MVT', 'Mouvement [entree(+) / sortie(-)]');

-- Insert into article
INSERT INTO article (article_ref, article_libelle, unit_code, cat_code, fab_id) VALUES 
('A001', 'Smartphone', 'PCS', 'CAT01', 'FAB001'),
('A002', 'Table', 'PCS', 'CAT02', 'FAB002'),
('A003', 'T-Shirt', 'PCS', 'CAT03', 'FAB003'),
('A004', 'Laptop', 'KG', 'CAT01', 'FAB001'),
('A005', 'Chair', 'PCS', 'CAT02', 'FAB002');

-- Insert into depot
INSERT INTO depot (depot_num, depot_nom, depot_superficie, depot_lat, depot_long, ville_nom, pays_nom) VALUES 
(1, 'Central Depot', 5000, 48.8566, 2.3522, 'Paris', 'France'),
(2, 'North Depot', 3000, 52.5200, 13.4050, 'Berlin', 'Germany'),
(3, 'West Depot', 4000, 40.7128, -74.0060, 'New York', 'USA'),
(4, 'East Depot', 6000, 35.6895, 139.6917, 'Tokyo', 'Japan');

-- Insert into mvt_stock
INSERT INTO mvt_stock (mvt_date_heure, mvt_qte, type_id, article_ref, depot_num) VALUES 
(GETDATE(), 100, 'T01', 'A001', 1),
(GETDATE(), 200, 'T01', 'A002', 2),
(GETDATE(), -50, 'T02', 'A001', 1),
(GETDATE(), 300, 'T01', 'A003', 3),
(GETDATE(), -100, 'T02', 'A003', 3),
(GETDATE(), 400, 'T01', 'A004', 4),
(GETDATE(), -150, 'T02', 'A004', 4),
(GETDATE(), 50, 'T03', 'A005', 1),
(GETDATE(), -30, 'T03', 'A005', 2);
