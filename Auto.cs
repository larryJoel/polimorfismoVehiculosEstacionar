class Auto:Vehiculo{
    string marca;

    public Auto(string mar): base(mar){
        marca = mar;
    }
    public override string ToString()
    {
        return $"Soy un auto, mi marca es: {marca}";
    }
}