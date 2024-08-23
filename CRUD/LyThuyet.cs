namespace CRUD
{
    public class LyThuyet
    {
        //Tìm hiểu Model binding 

        /*
         Model Binding là một cơ chế trong ASP.NET Core cho phép tự động ánh xạ dữ liệu từ các yêu cầu HTTP (như form submissions, query strings, route data, hoặc JSON payloads) vào các tham số của action method trong controller, hoặc vào các thuộc tính của các đối tượng model. 
            Điều này giúp bạn làm việc với dữ liệu dễ dàng hơn, vì bạn không cần phải xử lý dữ liệu từ yêu cầu HTTP một cách thủ công.

        Cách Model Binding hoạt động
            Khi một yêu cầu HTTP đến một action method trong controller, ASP.NET Core thực hiện các bước sau:

        Nhận dữ liệu từ yêu cầu:

            - Dữ liệu có thể đến từ các nguồn như route data, query strings, form data, hoặc body (đối với các yêu cầu POST hoặc PUT với dữ liệu JSON).
              Tìm kiếm các tham số cần bind:

            - ASP.NET Core sẽ tìm kiếm các tham số của action method cần được bind (kết nối) với dữ liệu từ yêu cầu. Các tham số này có thể là kiểu dữ liệu cơ bản như string, int, hoặc là các đối tượng phức tạp hơn như model class.
              Thực hiện quá trình binding:

            - ASP.NET Core sẽ cố gắng ánh xạ dữ liệu từ yêu cầu vào các tham số hoặc thuộc tính của model.
              Nếu model có các thuộc tính phức tạp, ASP.NET Core sẽ cố gắng bind các thuộc tính đó một cách đệ quy.
        Xác thực dữ liệu:

            - Sau khi binding, ASP.NET Core có thể thực hiện xác thực dữ liệu (nếu có sử dụng các thuộc tính validation trên model) và thêm các lỗi xác thực vào ModelState.
             Truyền dữ liệu vào action method:

            - Nếu binding và xác thực thành công, ASP.NET Core sẽ truyền các tham số vào action method và thực thi nó.
         */

        //Tìm hiểu validation

        /*
         Validation trong ASP.NET Core là quá trình kiểm tra tính hợp lệ của dữ liệu đầu vào để đảm bảo rằng dữ liệu đáp ứng các yêu cầu trước khi được xử lý hoặc lưu trữ. 
            ASP.NET Core hỗ trợ nhiều cách để thực hiện validation, bao gồm sử dụng Data Annotations, Validation Attributes, Custom Validation, và Fluent Validation.

        1. Data Annotations
            Data Annotations là cách đơn giản và phổ biến nhất để thêm các ràng buộc validation trực tiếp vào các thuộc tính của model thông qua các attribute. Dưới đây là một số attribute phổ biến:

                [Required]: Đảm bảo rằng một giá trị không được phép là null.
                [StringLength]: Đặt giới hạn độ dài của một chuỗi.
                [Range]: Đặt giá trị tối thiểu và tối đa cho một thuộc tính số hoặc ngày tháng.
                [EmailAddress]: Kiểm tra xem một chuỗi có phải là địa chỉ email hợp lệ hay không.
                [RegularExpression]: Kiểm tra giá trị dựa trên một biểu thức chính quy (regex).
        2. Server-side và Client-side Validation
            ASP.NET Core hỗ trợ cả server-side validation và client-side validation:

            Server-side validation: Khi người dùng gửi dữ liệu, dữ liệu sẽ được kiểm tra trên server. Nếu có lỗi, thông tin lỗi sẽ được gửi lại cho người dùng.

            Client-side validation: ASP.NET Core cũng có thể kiểm tra dữ liệu trên client trước khi gửi yêu cầu tới server, giúp giảm thiểu số lượng yêu cầu không hợp lệ được gửi tới server.
         */

        //Tìm hiểu Razor Page

        /*
         Razor Pages là một thành phần mới trong ASP.NET Core, ra mắt lần đầu trong phiên bản ASP.NET Core 2.0. Nó cung cấp một cách đơn giản và hiệu quả để xây dựng giao diện người dùng web với ASP.NET Core. 
            Razor Pages được thiết kế để làm cho mô hình lập trình trang Web trở nên đơn giản và dễ sử dụng hơn so với MVC truyền thống, bằng cách tập trung vào cách tiếp cận trang web với logic và giao diện kết hợp chặt chẽ.

         Cấu trúc Razor Pages
                Razor Pages thường bao gồm hai thành phần chính:

                Page Model: Đây là lớp C# (code-behind) tương tự như Controller trong MVC, xử lý logic cho trang. Lớp này thường có phần mở rộng .cshtml.cs.

                Razor Page: Đây là file giao diện của trang, được viết bằng cú pháp Razor và HTML. File này có phần mở rộng .cshtml.
         */
    }
}
