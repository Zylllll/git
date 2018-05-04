using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
   public class Grade
    {
       //拿一个泛型作为Grade的成员变量
       List<Student> list = new List<Student>();
       //遍历集合中的元素，，，，，，，，并且返回该元素
       public List<string> DisplayStudent(Point point) //中文意思：点 (X,Y)
       {
           int count = 0;
           List<string> newList = new List<string>();  //准备一个需要返回的空容器
           foreach (Student item in list)
           {
               count++;
               newList.Add(item.StuName + ":" + (point.X + 80 * count) + ":" + (point.Y + 50));
           }
           return newList;
       }
       //添加学生
       public void AddStudent(Student stu) 
       {
           list.Add(stu);
       }
    }
}
