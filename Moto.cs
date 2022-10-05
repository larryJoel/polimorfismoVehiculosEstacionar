class Moto:Vehiculo{
    string marca;

    public Moto(string mar): base(mar){
        marca = mar;
    }
    public override string ToString()
    {
        return $"Soy una moto, mi marca es: {marca}";
    }
}