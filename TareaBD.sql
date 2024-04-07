CREATE DATABASE TAREASBD

CREATE TABLE Cliente (
    IDCliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    CorreoElectronico NVARCHAR(100),
    Telefono NVARCHAR(20),
    Direccion NVARCHAR(100)
);

DROP TABLE IF EXISTS Cliente;

DROP TABLE IF EXISTS Pedido;

CREATE TABLE Pedido (
    IDPedido INT IDENTITY(1,1) PRIMARY KEY,
    IDCliente INT,
    Fecha DATETIME,
    Total MONEY,
    Estado NVARCHAR(50),
    FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente)
);



CREATE TABLE Ventas (
    IDVenta INT PRIMARY KEY IDENTITY,
    FechaVenta DATE,
    TotalVenta DECIMAL(10, 2)
);

CREATE TABLE Productos (
    IDProducto INT PRIMARY KEY IDENTITY,
    NombreProducto NVARCHAR(100),
    PrecioUnitario DECIMAL(10, 2)
);

CREATE TABLE DetalleVenta (
    IDDetalleVenta INT PRIMARY KEY IDENTITY,
    IDVenta INT,
    IDProducto INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10, 2),
    TotalDetalle DECIMAL(10, 2),
    FOREIGN KEY (IDVenta) REFERENCES Ventas(IDVenta),
    FOREIGN KEY (IDProducto) REFERENCES Productos(IDProducto)
);



SELECT IDProducto, NombreProducto, PrecioUnitario
FROM   Productos




INSERT INTO Productos (NombreProducto, PrecioUnitario)
VALUES
    ('Producto 1', 10.50),
    ('Producto 2', 20.25),
    ('Producto 3', 15.75),
    ('Producto 4', 8.99),
    ('Producto 5', 12.50),
    ('Producto 6', 18.75),
    ('Producto 7', 22.99),
    ('Producto 8', 9.99),
    ('Producto 9', 16.50),
    ('Producto 10', 14.25),
    ('Producto 11', 11.75),
    ('Producto 12', 7.99),
    ('Producto 13', 21.50),
    ('Producto 14', 19.25),
    ('Producto 15', 13.75),
    ('Producto 16', 6.99),
    ('Producto 17', 23.50),
    ('Producto 18', 17.25),
    ('Producto 19', 14.75),
    ('Producto 20', 10.99);
	INSERT INTO Ventas (FechaVenta, TotalVenta)
VALUES
    ('2024-04-01', 100.25),
    ('2024-04-02', 150.50),
    ('2024-04-03', 200.75),
    ('2024-04-04', 75.99),
    ('2024-04-05', 125.50),
    ('2024-04-06', 180.75),
    ('2024-04-07', 220.99),
    ('2024-04-08', 90.99),
    ('2024-04-09', 160.50),
    ('2024-04-10', 145.25),
    ('2024-04-11', 111.75),
    ('2024-04-12', 87.99),
    ('2024-04-13', 215.50),
    ('2024-04-14', 189.25),
    ('2024-04-15', 173.75),
    ('2024-04-16', 66.99),
    ('2024-04-17', 233.50),
    ('2024-04-18', 157.25),
    ('2024-04-19', 144.75),
    ('2024-04-20', 101.99);
INSERT INTO DetalleVenta (IDVenta, IDProducto, Cantidad, PrecioUnitario, TotalDetalle)
VALUES
    (1, 1, 5, 10.50, 52.50),
    (1, 2, 3, 20.25, 60.75),
    (2, 3, 2, 15.75, 31.50),
    (2, 4, 7, 8.99, 62.93),
    (3, 5, 4, 12.50, 50.00),
    (3, 6, 6, 18.75, 112.50),
    (4, 7, 1, 22.99, 22.99),
    (4, 8, 8, 9.99, 79.92),
    (5, 9, 3, 16.50, 49.50),
    (5, 10, 5, 14.25, 71.25),
    (6, 11, 2, 11.75, 23.50),
    (6, 12, 9, 7.99, 71.91),
    (7, 13, 6, 21.50, 129.00),
    (7, 14, 4, 19.25, 77.00),
    (8, 15, 3, 13.75, 41.25),
    (8, 16, 7, 6.99, 48.93),
    (9, 17, 5, 23.50, 117.50),
    (9, 18, 2, 17.25, 34.50),
    (10, 19, 1, 14.75, 14.75),
    (10, 20, 4, 10.99, 43.96);



INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES 
('Juan', 'Pérez', 'juan@example.com', '123456789', 'Calle Principal 123'),
('María', 'González', 'maria@example.com', '987654321', 'Avenida Central 456'),
('Pedro', 'Martínez', 'pedro@example.com', '456789123', 'Plaza Mayor 789'),
('Ana', 'Sánchez', 'ana@example.com', '321654987', 'Boulevard Norte 567'),
('Carlos', 'López', 'carlos@example.com', '789123456', 'Camino Real 890'),
('Laura', 'Rodríguez', 'laura@example.com', '654987321', 'Paseo del Sol 1234'),
('Daniel', 'Fernández', 'daniel@example.com', '147258369', 'Callejón Estrecho 5678'),
('Sofía', 'Díaz', 'sofia@example.com', '258369147', 'Calle de la Luna 9012'),
('Pablo', 'Hernández', 'pablo@example.com', '369147258', 'Avenida del Bosque 3456'),
('Luisa', 'Gómez', 'luisa@example.com', '963852741', 'Avenida del Río 7890'),
('Martín', 'Pérez', 'martin@example.com', '852963147', 'Calle Mayor 123'),
('Lucía', 'Vázquez', 'lucia@example.com', '741852963', 'Plaza del Sol 456'),
('Elena', 'López', 'elena@example.com', '123789456', 'Callejón de la Cruz 789'),
('Javier', 'Ruiz', 'javier@example.com', '456123789', 'Boulevard Sur 1234'),
('Carmen', 'Torres', 'carmen@example.com', '789456123', 'Paseo de la Playa 5678');


select * from Cliente

INSERT INTO Pedido (IDCliente, Fecha, Total, Estado)
VALUES 
(1, '2024-04-01T08:00:00', 150.50, 'pendiente'),
(2, '2024-04-02T10:30:00', 200.75, 'en proceso'),
(3, '2024-04-03T12:15:00', 300.25, 'completado'),
(4, '2024-04-04T14:45:00', 80.00, 'completado'),
(5, '2024-04-05T16:20:00', 150.00, 'en proceso'),
(6, '2024-04-06T18:45:00', 200.00, 'pendiente'),
(7, '2024-04-07T20:10:00', 180.67, 'completado'),
(8, '2024-04-08T22:30:00', 90.31, 'en proceso'),
(9, '2024-04-09T09:45:00', 60.67, 'completado'),
(10, '2024-04-10T11:20:00', 500.00, 'pendiente'),
(11, '2024-04-11T13:30:00', 100.34, 'pendiente'),
(12, '2024-04-12T15:40:00', 320.45, 'completado'),
(13, '2024-04-13T17:00:00', 40.04, 'pendiente'),
(14, '2024-04-14T19:20:00', 70.67, 'completado'),
(15, '2024-04-15T21:45:00', 200.05, 'en proceso');
insert into Pedido values (3, '2024-04-15T21:45:00', 265.05, 'en proceso');

	select * from Pedido