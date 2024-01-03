using System;

// 1.IOutput
public interface IOutput
{
    void Show();
    void Show(string info);
}

// 2.IMath
public interface IMath
{
    int Max();
    int Min();
    double Avg();
    bool Search(int valueToSearch);
}

// 3.ISort
public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

// MyArray
public class MyArray : IOutput, IMath, ISort
{
    private int[] array;

    public MyArray(int[] values)
    {
        array = values;
    }

    // 1.IOutput
    public void Show()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
        
    public void Show(string info)
    {
        Console.WriteLine($"Елементи масиву: {info}");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // IMath
    public int Max()
    {
        return array.Max();
    }
    
    public int Min()
    {
        return array.Min();
    }

    public double Avg()
    {
        return array.Average();
    }

    public bool Search(int valueToSearch)
    {
        return array.Contains(valueToSearch);
    }

    // 3.ISort
    public void SortAsc()
    {
        Array.Sort(array);
    }

    public void SortDesc()
    {
        Array.Sort(array);
        Array.Reverse(array);
    }
        
    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            Array.Sort(array);
        }
        else
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
    }
}

class Program
{
    static void Main()
    {        
        int[] testArray = { 101, 21, 33, 42, 54 };
        MyArray myArray = new MyArray(testArray);

        myArray.Show();
        myArray.Show("Test Array");

        Console.WriteLine($"Максимум: {myArray.Max()}");
        Console.WriteLine($"Мінімум: {myArray.Min()}");
        Console.WriteLine($"Середнє арифметичне: {myArray.Avg()}");

        int valueToSearch = 3;
        if (myArray.Search(valueToSearch))
        {
            Console.WriteLine($"Значення {valueToSearch} знайдено в масиві.");
        }
        else
        {
            Console.WriteLine($"Значення {valueToSearch} не знайдено в масиві.");
        }


        Console.WriteLine("Сортування за зростанням:");
        myArray.SortAsc();
        myArray.Show();

        Console.WriteLine("Сортування за спаданням:");
        myArray.SortDesc();
        myArray.Show();

        Console.WriteLine("Сортування в залежності від параметра (true - за зростанням, false - за спаданням):");
        myArray.SortByParam(false);
        myArray.Show();


        Console.ReadLine(); 
    }
}
