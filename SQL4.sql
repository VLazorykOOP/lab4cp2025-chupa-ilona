CREATE DATABASE IF NOT EXISTS library_db;
USE library_db;

DROP TABLE IF EXISTS books;
CREATE TABLE books (
    id INT AUTO_INCREMENT PRIMARY KEY,
    author VARCHAR(255),
    title VARCHAR(255),
    publisher VARCHAR(255),
    page_count INT,
    genre VARCHAR(100),
    price DECIMAL(10,2),
    storage VARCHAR(100),
    inventory_number VARCHAR(100) UNIQUE
);

INSERT INTO books (author, title, publisher, page_count, genre, price, storage, inventory_number) VALUES
('Джордж Орвелл', '1984', 'Видавництво Старого Лева', 328, 'Антиутопія', 210.00, 'Полиця А1', 'INV001'),
('Леся Українка', 'Лісова пісня', 'Основи', 160, 'Драма-феєрія', 180.50, 'Полиця B2', 'INV002');

DROP TABLE IF EXISTS users;
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE,
    password VARCHAR(50),
    role ENUM('admin', 'worker')
);

INSERT INTO users (username, password, role) VALUES
('admin', 'admin123', 'admin'),
('worker', 'worker123', 'worker');
