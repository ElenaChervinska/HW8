//Інтерфейс IItem був функціональним інтерфейсом. Це порушує принцип про поділ інтерфейсу,
//оскільки при реалізації інтерфейсу IItem класом, який не використовує частину методу,
//потрібно було б залишати їх порожніми. Набагато доречнiше розбити інтерфейси на дрібніші
//за своєю бізнес логікою і вже реалізувати класи від них.
interface ISeller
{
    void ApplyDiscount(String discount);

    void SetPrice(double price);
}

interface ISellerViaPromocode : ISeller
{
    void ApplyPromocode(String promocode);
}
interface IWearSeller : ISeller
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : ISellerViaPromocode
{
    public void ApplyDiscount(string discount)
    {
        throw new NotImplementedException();
    }

    public void ApplyPromocode(string promocode)
    {
        throw new NotImplementedException();
    }

    public void SetPrice(double price)
    {
        throw new NotImplementedException();
    }
}

class OutWear : IWearSeller
{
    public void ApplyDiscount(string discount)
    {
        throw new NotImplementedException();
    }

    public void SetColor(byte color)
    {
        throw new NotImplementedException();
    }

    public void SetPrice(double price)
    {
        throw new NotImplementedException();
    }

    public void SetSize(byte size)
    {
        throw new NotImplementedException();
    }
}