class Estacionamiento{
    string nombre;
    public Estacionamiento(string nomb){
        nombre = nomb;
    }
    public void estacionarVehiculo(Vehiculo v){
        Console.WriteLine("Vehiculo estacionado " + v);
    }
}