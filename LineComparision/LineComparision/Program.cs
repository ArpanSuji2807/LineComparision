using LineComparision;
Comparision comparision = new Comparision(1, 2, 3, 4);
comparision.CalculateLength();
Comparision L1 = new Comparision(1, 2, 3, 4);
L1.CalculateLength();
Comparision L2 = new Comparision(1, 2, 3, 4);
L2.CalculateLength();

if (L1.Equals(L2))
{
    Console.WriteLine("Both lines are equal");
}
else
{
    Console.WriteLine("Both lines are not equal");
}
