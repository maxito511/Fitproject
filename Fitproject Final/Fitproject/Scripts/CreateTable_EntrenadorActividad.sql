create table entrenadorxactividad (
	id_entrenador int not null,
	id_actividad int not null,
	primary key (id_entrenador,id_actividad),
	)
alter table entrenadorxactividad
add foreign key (id_entrenador) references entrenadores(id_entrenador)
alter table entrenadorxactividad
add foreign key (id_actividad) references actividades(id_actividad)
