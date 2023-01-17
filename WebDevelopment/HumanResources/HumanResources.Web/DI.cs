class A
{
    IB b;

    public A(IB b)
    {
        this.b = b;
    }
}

class B : IB
{
}

class E: IB
{

}

class C
{
    IB b = new B();
}

interface IB
{
}
