# Quy tắc làm việc trong repository

## Phạm vi

Áp dụng cho toàn bộ repository. Đọc thêm `AGENTS.md` trong thư mục con trước khi làm việc tại đó. Chỉ dẫn trực tiếp của người dùng được ưu tiên khi có xung đột.

## Đề xuất và phê duyệt trước khi thay đổi

1. Có thể đọc, tìm kiếm và phân tích tệp để chuẩn bị phương án mà không cần xin phép. Không thực hiện thao tác ghi trong giai đoạn này.
2. Trước khi tạo, sửa, xóa, đổi tên hoặc di chuyển bất kỳ tệp nào, trình bày phương án để người dùng xem xét. Nêu rõ đường dẫn từng tệp, vấn đề cần giải quyết, nội dung dự kiến, lựa chọn hoặc đánh đổi đáng chú ý và cách kiểm chứng.
3. Sau khi trình bày phương án, dừng và chờ người dùng phê duyệt rõ ràng. Một yêu cầu chung như “cập nhật sơ đồ” chưa thay thế việc phê duyệt phương án cụ thể; không xem sự im lặng là đồng ý.
4. Chỉ áp dụng các thay đổi trong phạm vi đã được phê duyệt. Không hỏi lại cho cùng phương án đã được duyệt. Nếu phát sinh tệp hoặc thay đổi ngoài phạm vi, trình bày bổ sung và chờ phê duyệt trước khi thực hiện phần đó.
5. Giữ nguyên thay đổi sẵn có của người dùng. Không hoàn tác, ghi đè hoặc dọn dẹp tệp ngoài phạm vi được duyệt.
6. Quy trình này cũng áp dụng cho mã nguồn, tài liệu, sơ đồ, cấu hình và chính các tệp hướng dẫn agent. Không dùng công cụ hoặc lệnh có tác dụng ghi ngầm để bỏ qua bước phê duyệt.

## Áp dụng và kiểm chứng

- Dùng tiếng Anh khi trao đổi và thảo luận phương án với người dùng, bao gồm đề xuất, câu hỏi phê duyệt, cập nhật tiến độ và báo cáo kết quả.
- Dùng tiếng Việt cho nội dung các tệp đầu ra, bao gồm tài liệu và nhãn sơ đồ, ngoại trừ tệp nhật ký dùng tiếng Anh. Giữ nguyên tên công nghệ, API và định danh cần thiết.
- Thực hiện kiểm tra phù hợp với thay đổi đã duyệt. Nếu công cụ kiểm tra tạo hoặc sửa tệp trong repository, đưa các đầu ra đó vào phương án trước khi chạy.
- Phân biệt thiết kế dự kiến, phần đã hiện thực và kết quả đã kiểm chứng. Không tự chốt luật chơi còn mở hoặc tuyên bố kiểm thử thành công khi chưa chạy.
- Với draw.io, tuân thủ thêm `docs/diagram/AGENTS.md`; kiểm tra XML, ID, tham chiếu và giữ nguyên các trang hoặc chú giải ngoài phạm vi.

## Nhật ký sau khi thay đổi

- Dùng tệp `agent.md` ở thư mục gốc làm nhật ký chung; không nhầm với `AGENTS.md`, là tệp quy tắc.
- Viết nội dung nhật ký bằng tiếng Anh, bao gồm `agent.md` và các design log chuyên biệt.
- Trong mỗi phương án, nêu việc cập nhật `agent.md` cùng các tệp chuyên biệt cần ghi nhật ký. Khi người dùng duyệt phương án đó, cập nhật nhật ký sau khi thực hiện và kiểm chứng; không cần xin duyệt lại cho cùng mục nhật ký đã được nêu.
- Mỗi mục ghi ngày, yêu cầu hoặc căn cứ phê duyệt, các tệp đã thay đổi, nội dung chính, kết quả kiểm chứng và giới hạn hoặc việc còn chờ.
- Chỉ nối thêm nhật ký; giữ lịch sử trước đó. Không ghi bí mật, token hoặc thông tin nhạy cảm.
- Tiếp tục cập nhật các design log chuyên biệt nếu hướng dẫn thư mục yêu cầu; nhật ký chung không thay thế các tệp đó.
