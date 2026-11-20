# Examen_RentCar_Wilson

 RentCar Express — Parcial de C# Windows Forms

Nombre y matrícula
Nombre: Wilson Alejandro Abreu Santana
Matrícula: 2025-2391

 Descripción del programa:
Aplicación de escritorio desarrollada para la empresa RentCar Express, diseñada para registrar alquileres de vehículos, aplicar opciones de seguro, GPS y entrega, visualizar el detalle en una lista con formato de columnas y calcular los montos del alquiler, esto es muy importante ya que así se lleva una mejor organización tanto financiera y se ahorra mucho tiempo.

 Datos de entrada:
Datos generales del alquiler: nombre del cliente, casilla de cliente corporativo, y fecha de salida,
Datos del vehículo: nombre del vehículo (txtVehiculo), tarifa diaria en RD$ (txtTarifa) y cantidad de días (nudDias, configurado en rango de 1 a 30).
Opciones adicionales: tipo de seguro (rbtBasico o rbtCompleto con cargo de +RD$300), GPS (chkGps con cargo de +RD$100) y tipo de entrega (rbtSucursal o rbtDomicilio con cargo de +RD$500).

 Proceso:
Registro de alquiler (btnAgregar): toma el vehículo, la tarifa diaria y los cargos aplicables según el seguro seleccionado (+RD$300 si es completo) y el GPS (+RD$100 si está marcado), calcula el total por línea multiplicando la tarifa por la cantidad de días, acumula el subtotal, agrega la fila formateada a lstAlquileres y limpia/reinicia los controles del vehículo.
Cálculo de totales: valida que exista al menos un vehículo agregado en lstAlquileres y calcula el descuento corporativo del 15% (si aplica), el costo de entrega a domicilio de RD$500 (si aplica), la base imponible, el ITBIS del 18% y el total a pagar.
Limpieza y cierre: el botón de nuevo alquiler reinicia el acumulado, limpia los campos y devuelve el foco al cliente, mientras que el botón de salir cierra la ventana.

 
 Salida:
Detalle de alquileres (lstAlquileres): muestra cada vehículo agregado con cantidad de días, nombre del vehículo, tipo de seguro entre paréntesis, tarifa y total de línea. muestra los valores calculados para descuento, domicilio, ITBIS (18%) y total a pagar en pesos dominicanos (RD$).

 
 Capturas de pantalla del programa en ejecución
<img width="1917" height="1077" alt="Captura de pantalla 2026-11-19 203436" src="https://github.com/user-attachments/assets/9267020a-9adb-4f30-98b7-f233c99c00df" />
<img width="1902" height="1022" alt="Captura de pantalla 2026-11-19 203850" src="https://github.com/user-attachments/assets/e941614a-cfb7-4d37-9273-e360da40597b" />

Formulario con alquileres agregados:
Cálculo de totales en pantalla:
<img width="1917" height="1022" alt="Captura de pantalla 2026-11-19 203901" src="https://github.com/user-attachments/assets/1b246fba-46a9-4e87-9fa9-c21660083db6" />
