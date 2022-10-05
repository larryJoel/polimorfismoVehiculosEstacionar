class Camioneta:Vehiculo{
    string marca;

    public Camioneta(string mar): base(mar){
        marca = mar;
    }
    public override string ToString()
    {
        return $"soy una camioneta, mi marca es: {marca}";
    }
}