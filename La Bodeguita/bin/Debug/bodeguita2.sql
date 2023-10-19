DROP DATABASE IF EXISTS bodeguita2;
CREATE DATABASE bodeguita2;

USE bodeguita2;

CREATE TABLE proveedores (
  Id_proveedor  integer AUTO_INCREMENT NOT NULL PRIMARY KEY,
  nombre        varchar(70) NOT NULL,
  direccion     varchar(100) NOT NULL,
  telefono      varchar(15),
  rfc           varchar(15) NOT NULL,
  mail          varchar(30)
) ENGINE = InnoDB;



CREATE TABLE empleados (
  Id_empleado   int AUTO_INCREMENT NOT NULL PRIMARY KEY,
  nombre        varchar(30) NOT NULL,
  apellidos     varchar(100) NOT NULL,
  direccion     varchar(100) NOT NULL,
  telefono      varchar(15),
  usuario       varchar(20),
  contra        varchar(20),
  tipo_usuario  varchar(20)
) ENGINE = InnoDB;

insert into empleados(nombre,apellidos,direccion,telefono,usuario,contra,tipo_usuario) values('administrador','administrador principal','conocido','0000000','admin','admin','Administrador');

CREATE TABLE articulos_2 (
  id_articulo   integer AUTO_INCREMENT NOT NULL PRIMARY KEY,
  descripcion   varchar(50) NOT NULL COMMENT 'descripcion del articulo',
  presentacion  varchar(15) NOT NULL,
  precio        decimal(10,2) NOT NULL,
  existencia    decimal(10,2) NOT NULL,
  precio_caja decimal(10,2),
  pza_caja integer,
  id_proveedor  integer NOT NULL COMMENT 'clave del proveedor del articulo',
  /* Foreign keys */
  CONSTRAINT fk1
    FOREIGN KEY (id_proveedor)
    REFERENCES proveedores(Id_proveedor)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;

CREATE TABLE articulos(
  codigo varchar(25) not null primary key,
  presentacion varchar(100) not null,
  precio decimal(10,2) not null,
  existencia integer not null,
  precio_caja decimal(10,2),
  pza_caja integer,
  id_proveedor integer not null,
  /* claves foraneas */
 CONSTRAINT fk_1
    FOREIGN KEY (id_proveedor)
    REFERENCES proveedores(id_proveedor)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;


CREATE TABLE ventas (
  folio        integer AUTO_INCREMENT NOT NULL PRIMARY KEY,
  fecha        date NOT NULL,
  total        decimal(10,2) NOT NULL,
  id_empleado  integer NOT NULL,
    /* Foreign keys */
  CONSTRAINT fork1
    FOREIGN KEY (id_empleado)
    REFERENCES empleados(Id_empleado)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;

CREATE TABLE venta_articulo (
  id_vart integer  auto_increment not null primary key,
  folio        integer NOT NULL,
  id_articulo  varchar(20) NOT NULL,
  cantidad     int NOT NULL,
  descripcion  varchar(50) NOT NULL,
  precio       decimal(10,2) NOT NULL,
  importe      decimal(10,2) NOT NULL,
 /* Foreign keys */
  CONSTRAINT fork2
    FOREIGN KEY (folio)
    REFERENCES ventas(folio)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;