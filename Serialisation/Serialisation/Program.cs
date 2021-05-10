using System;

namespace Serialisation
{
    class Program
    {
        private static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static ISerialize _serializer;
        static void Main(string[] args)
        {
            ////Create a Trainee
            var trainee = new Trainee { FirstName = "Hamse", LastName = "Ahmed", SpartaNo = 100 };

            ////Crete a binary serializer
            //var serializer = new SerializerBinary();
            //serializer.SerializeToFile($"{_path}/BinaryTrainee.bin", trainee);

            ////Read the trainee back
            //var deserialisedBinaryTrainee = serializer.DeserializeFromFile<Trainee>($"{_path}/BinaryTrainee.bin");

            ////Serialize our trainee in xml
            _serializer = new SerealizerXML();
            ////write trainee to file(xml)
            //_serializer.SerialiseToFile($"{_path}/XMLTrainee.xml", trainee);

            ////Create and Serialize a Course to XML
            var eng86 = new Course { Title = "Engineering86", Subject = "C# SDET", StartDate = new DateTime(2021, 5, 3) };
            //eng86.AddTrainee(trainee);
            //eng86.AddTrainee(new Trainee { FirstName = "Uzair", LastName = "Khan", SpartaNo = 101 });
            //_serializer.SerialiseToFile($"{_path}/XMLCourse.xml", eng86);
            ////var editedCourse = _serializer.DeserialiseFromFile<Course>($"{_path}/XMLCourseEdited.xml");
            ///

            _serializer = new SerializeJSON();
            _serializer.SerialiseToFile($"{_path}/JsonTrainee.json", trainee);
            _serializer.SerialiseToFile($"{_path}/JsonCourse.json", eng86);
            ////Open edited version
            //var editedCourse2 = _serializer.DeserialiseFromFile<Course>($"{_path}/JsonCourse2.json");
        }
    }
}
