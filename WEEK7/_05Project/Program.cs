using _05Project;

// Define List
List<ClassRoom> classRooms = new List<ClassRoom>()
{
    new ClassRoom(1, "Matematik"),    
    new ClassRoom(2, "Türkçe"),    
    new ClassRoom(3, "Kimya"),    
};

List<Student> students = new List<Student>()
{
    new Student(1, 1, "Ali"),
    new Student(2, 2, "Ayşe"),
    new Student(3, 1, "Mehmet"),
    new Student(4, 3, "Fatma"),
    new Student(5, 2, "Ahmet"),
};

// ------------ QUERY 1
var dataSource = classRooms.GroupJoin(
    students,
    classRoom => classRoom.Id,
    student => student.ClassRoomId,
    (classRoom, groupStudent) => new
    {
        ClassName = classRoom,
        Students = groupStudent.ToList()
    }
);

foreach (var group in dataSource)
{
    // Write Class Name
    Console.WriteLine(group.ClassName);

    // Loop Students
    foreach (var student in group.Students) Console.WriteLine(student);
    
    // 
    Console.WriteLine("-----------------------");
}

Console.WriteLine();
Console.WriteLine("--------------------------------------");
Console.WriteLine();

// ------------ QUERY 2
var dataSource2 = from classRoom in classRooms
    join student in students on classRoom.Id equals student.ClassRoomId into studentGroups
    select new 
    {
        ClassName = classRoom,
        Students = studentGroups
    };
    
foreach (var group in dataSource2)
{
    // Write Class Name
    Console.WriteLine(group.ClassName);

    // Loop Students
    foreach (var student in group.Students) Console.WriteLine(student);
    
    // 
    Console.WriteLine("-----------------------");
}
