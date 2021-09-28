select NroFactura = factura.id_factura,
	   NroSocio = socios.id_socio,
	   Socio = socios.apellido+' '+socios.nombre,
	   factura.fe_factura,
	   actividades.de_actividad,	
	   actividades.pr_actividad,
	   factura.*
from factura, factura_detalle, socioxactividad, socios, actividades, tipo_pago
where factura.id_tipo = tipo_pago.id_tipo 
and factura.id_factura = factura_detalle.id_factura
and factura.id_socio = socios.id_socio
and socios.id_socio = socioxactividad.id_socio
and socioxactividad.id_actividad = actividades.id_actividad
and socios.dni = 11111111
and fe_factura = '01.11.2017'