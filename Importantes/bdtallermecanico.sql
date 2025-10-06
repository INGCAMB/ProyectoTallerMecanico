CREATE TABLE `dueno` (
  `id_dueno` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `domicilio` varchar(50) NOT NULL,
  `telefono` varchar(11) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `mecanico` (
  `id_mecanico` int(11) NOT NULL,
  `id_vehiculo` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `reparacion` (
  `id_reparacion` int(11) NOT NULL,
  `id_mecanico` int(11) NOT NULL,
  `tipo_reparacion` varchar(60) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `contra` varchar(25) NOT NULL,
  `admin` tinyint(1) NOT NULL,
  `tipo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `vehiculo` (
  `id_vehiculo` int(11) NOT NULL,
  `id_dueno` int(11) NOT NULL,
  `matricula` varchar(30) NOT NULL,
  `modelo` varchar(30) NOT NULL,
  `marca` varchar(20) NOT NULL,
  `presupuesto` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

ALTER TABLE `dueno`
  ADD PRIMARY KEY (`id_dueno`);
ALTER TABLE `mecanico`
  ADD PRIMARY KEY (`id_mecanico`);
ALTER TABLE `reparacion`
  ADD PRIMARY KEY (`id_reparacion`);
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`);
ALTER TABLE `vehiculo`
  ADD PRIMARY KEY (`id_vehiculo`);

ALTER TABLE `dueno`
  MODIFY `id_dueno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `mecanico`
  MODIFY `id_mecanico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `reparacion`
  MODIFY `id_reparacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `vehiculo`
  MODIFY `id_vehiculo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
COMMIT;
