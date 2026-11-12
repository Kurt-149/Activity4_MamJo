
CREATE DATABASE IF NOT EXISTS activity_DB
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_general_ci;

USE activity_DB;

CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100) NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    `role` VARCHAR(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS products (
    id INT AUTO_INCREMENT PRIMARY KEY,
    code VARCHAR(20) NOT NULL UNIQUE,
    product_name VARCHAR(100) NOT NULL,
    category VARCHAR(50) NOT NULL,
    qty INT NOT NULL,
    price DECIMAL(10,2) NOT NULL
);

INSERT IGNORE INTO products (code, product_name, category, qty, price) VALUES
('WRT-001', 'Ballpen', 'Writing', 120, 10.00),
('PPR-001', 'Notebook', 'Paper', 8, 45.00),
('ART-001', 'Crayons', 'Art', 60, 35.00),
('BAG-001', 'School bag', 'Bags', 15, 450.00),
('WRT-002', 'Pencil', 'Writing', 200, 8.00),
('WRT-003', 'Eraser', 'Writing', 90, 5.00),
('TLS-001', 'Ruler', 'Tools', 45, 12.00),
('ART-002', 'Glue', 'Art', 30, 20.00);