using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Infrastructure.SharedKernel
{
    //kiểu Generic T : ứng với từng loại data entity sẽ có kiểu Id khác nhau
    public class DomainEntity<T>
    {
        public T Id { get; set; }
        //hàm istransient sẽ kiểm tra có giá trị gán vào kiểu T chưa
        //trả về True : khi đã có giá trị gán
        //trả về False: khi chưa có giá trị gán
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
    
}
