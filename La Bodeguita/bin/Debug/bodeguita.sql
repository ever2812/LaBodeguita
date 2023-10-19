CREATE DATABASE bodeguita;

CREATE TABLE presentaciones (
  Id_presentacion  integer AUTO_INCREMENT NOT NULL PRIMARY KEY,
  nombre           varchar(70) NOT NULL,
  precio           decimal(10,2) NOT NULL
) ENGINE = InnoDB;


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


CREATE TABLE articulos (
  id_art           integer AUTO_INCREMENT NOT NULL PRIMARY KEY COMMENT 'clave del articulo',
  codigo           varchar(20) NOT NULL COMMENT 'codigo de barras del articulo',
  id_presentacion  integer NOT NULL COMMENT 'clave de la presentacion',
  id_proveedor     integer NOT NULL COMMENT 'clave del proveedor',
  /* Foreign keys */
  CONSTRAINT fk_1
    FOREIGN KEY (id_presentacion)
    REFERENCES presentaciones(id_presentacion)
    ON DELETE RESTRICT
    ON UPDATE CASCADE, 
  CONSTRAINT fk_2
    FOREIGN KEY (id_proveedor)
    REFERENCES proveedores(id_proveedor)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;


CREATE TABLE articulos_2 (
  id_articulo   integer AUTO_INCREMENT NOT NULL PRIMARY KEY,
  descripcion   varchar(50) NOT NULL COMMENT 'descripcion del articulo',
  presentacion  varchar(15) NOT NULL,
  precio        decimal(10,2) NOT NULL,
  existencia    decimal(10,2) NOT NULL,
  id_proveedor  integer NOT NULL COMMENT 'clave del proveedor del articulo',
  /* Foreign keys */
  CONSTRAINT fk1
    FOREIGN KEY (id_proveedor)
    REFERENCES proveedores(Id_proveedor)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;


--Table: ventas

--DROP TABLE IF EXISTS ventas;

CREATE TABLE ventas (
  folio        int AUTO_INCREMENT NOT NULL,
  fecha        date NOT NULL,
  total        decimal(10,2) NOT NULL,
  id_empleado  int NOT NULL,
  /* Keys */
  PRIMARY KEY (folio),
  /* Foreign keys */
  CONSTRAINT fork1
    FOREIGN KEY (id_empleado)
    REFERENCES empleados(Id_empleado)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;


--Table: venta_articulo

--DROP TABLE IF EXISTS venta_articulo;

CREATE TABLE venta_articulo (
  folio        int NOT NULL,
  id_articulo  varchar(20) NOT NULL,
  cantidad     int NOT NULL,
  descripcion  varchar(50) NOT NULL,
  precio       decimal(10,2) NOT NULL,
  importe      decimal(10,2) NOT NULL,
  /* Keys */
  PRIMARY KEY (folio, id_articulo),
  /* Foreign keys */
  CONSTRAINT fork2
    FOREIGN KEY (folio)
    REFERENCES ventas(folio)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE = InnoDB;