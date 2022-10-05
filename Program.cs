Vehiculo[] misVEhiculos = new Vehiculo[4];
misVEhiculos[0] = new Vehiculo("Generico");
misVEhiculos[1] = new Auto("Fiat Palio");
misVEhiculos[2] = new Moto("Yamaha YBR");
misVEhiculos[3] = new Camioneta("VW Amarok");

Estacionamiento parking =  new Estacionamiento("MI estacion");
foreach (var v in misVEhiculos)
{   
    parking.estacionarVehiculo(v);
}