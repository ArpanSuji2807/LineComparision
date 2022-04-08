using LineComparision;
Comparision comparision = new Comparision(1, 2, 3, 4);
comparision.CalculateLength();
Comparision line1 = new Comparision(1, 2, 3, 4);
line1.CalculateLength();
Comparision line2 = new Comparision(1, 2, 3, 4);
line2.CalculateLength();

if (line1.Equals(line2))
{
    Console.WriteLine("Both lines are equal");
}
else
{
    Console.WriteLine("Both lines are not equal");
}
