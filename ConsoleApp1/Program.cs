//int x = 2;
//int y = 2;
//int z = 90;
//int w;

//Console.WriteLine("Before ref:");
//Console.WriteLine($"x: {x}");
//Console.WriteLine($"y: {y}");
//Console.WriteLine("z: no value");
//Console.WriteLine("w: no value");

//int v = ByRef(ref x, ref y, out z, out w,ref arr);

//Console.WriteLine("After ref:");
//Console.WriteLine($"x: {x}");
//Console.WriteLine($"y: {y}");
//Console.WriteLine($"z: {z}");
//Console.WriteLine($"w: {w}");
//Console.WriteLine($"v: {v}");
//Console.WriteLine($"array: {string.Join(", ", arr)}");

//static int ByRef(ref int x, ref int y, out int z, out int w, ref int[] arr)
//{
//	x = x * x;
//	y = y * y;
//	z = 10;
//	w = 20;


//	int i = 0;
//	int j = 1;

//	while (i < j)
//	{ 
//		int temp = arr[i];
//		arr[i] = arr[j];
//		arr[j] = temp;

//		i++;
//		j--;
//	}

//	return 0;
//}




//int[] arr = [1, 2, 3, 4, 5];

//Console.WriteLine($"Original: {string.Join(", ", arr)}");

//ChangeByRef(ref arr);

//ChangeByValue(arr);


//Console.WriteLine($"Modify: {string.Join(", ", arr)}");


//static void ChangeByRef(ref int[] a)
//{
//	a[0] = 10;
//}

//static void ChangeByValue(int[] a)
//{
//	a[3] = 200;
//}









//int[] arr;


//static void FillArray(out int[] a)
//{
//	a = new int[5];

//	for (int i = 0; i < a.Length; i++)
//	{
//		a[i] = i + 1;
//	}
//}


//FillArray(out arr);

//Console.WriteLine("Array elements are:");
//for (int i = 0; i < arr.Length; i++)
//{
//	Console.WriteLine(arr[i]);
//}

//int[] newArr;
//FillArray(out newArr);

//Console.WriteLine("New array elements are:");
//for (int i = 0; i < newArr.Length; i++)
//{
//	Console.WriteLine(newArr[i]);
//}

//Console.WriteLine("Original array elements are:");
//for (int i = 0; i < arr.Length; i++)
//{
//	Console.WriteLine(arr[i]);
//}

//string name;

//OutMethod(out name);

//Console.WriteLine($"{name}");

//void OutMethod(out string name)
//{
//    name = "yazan";
//}
















//using Dumpify;

//class Program {
//    static void Main(string[] args) {



//        var point1 = new Point(2, 3) { Id = 2 };
//        var point2 = new Point(2, 3) { Id = 2 };

//        bool areEqualMethod = point1.Equals(point2);
//        bool areEqualOperator = point1 == point2;

//        areEqualMethod.Dump("Method");
//        areEqualOperator.Dump("Operator");



//    }


//}

//try ( class )
//public record struct Point {

//    private readonly int _x;
//    private readonly int _y;

//    public Point(int x, int y) {
//        _x = x;
//        _y = y;
//    }
//    public int Id { get; init; }

//    //public override bool Equals(object obj) {

//    //    if (obj == null || !this.GetType().Equals(obj.GetType())) {
//    //        return false;
//    //    }
//    //    else {
//    //        Point p = (Point)obj;
//    //        return (_x == p._x) && (_y == p._y);
//    //    }
//    //}

//    //public override int GetHashCode() {
//    //    return HashCode.Combine(_x, _y);
//    //}
//}





//class Program {


//    static void Main(string[] args) {

//        List<Employee>? employees = new() {

//            new Employee { Id = 2, Name = "ali" },
//            new Employee() { Id = 3, Name = "yara" },
//            new Employee() { Id = 1, Name = "yazan" },
//            new Employee() { Id = 5, Name = "bayan" },
//            new Employee() { Id = 4, Name = "mayar" }
//        };


//        employees.Sort();


//        SortByName sortByName = new();

//        employees.Sort(sortByName);

//        foreach (var employee in employees) {

//            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}");
//        }



//    }
//}





//class Employee : IComparable<Employee> {
//    public required int Id { get; set; } = 0;
//    public string Name { get; set; } = string.Empty;

//    public int CompareTo(Employee? employee) {
//        if (this.Id > employee.Id)
//            return 1;
//        else if (this.Id < employee.Id)
//            return -1;
//        else
//            return 0;
//    }
//}

//class SortByName : IComparer<Employee> {
//    public int Compare(Employee? x, Employee? y) {
//        return x.Name.CompareTo(y.Name);
//    }
//}

