# Quy chuẩn trình bày và checklist nghiệm thu

Cập nhật: 13/11/2026. Dùng cùng [đề cương](report-structure-and-content.md) và [thiết kế Imposter](imposter-mode-design.md). Các thông số trình bày là đề xuất nội bộ; mẫu bắt buộc của giảng viên được ưu tiên nếu có.

## 1. Trình bày

| Thành phần | Quy chuẩn đề xuất |
| --- | --- |
| Khổ giấy | A4 dọc; trang ngang khi sơ đồ rộng cần thêm chỗ |
| Lề | Trái 3 cm; phải, trên và dưới 2 cm |
| Nội dung | Times New Roman 13 pt; giãn dòng 1,3; sau đoạn 6 pt |
| Chương | Heading 1, 16 pt đậm; bắt đầu trang mới |
| Mục | Heading 2, 14 pt đậm; tối đa ba cấp tiêu đề |
| Caption/bảng | 11–12 pt; caption dưới hình, trên bảng |
| Đánh số | Mục theo chương; hình/bảng theo chương, ví dụ Hình 2.1 |
| Mục lục | Tự động từ Heading styles; cập nhật sau lần sửa cuối |

Dùng page break và paragraph spacing, không căn trang bằng hàng loạt dòng trống. Giữ tiêu đề với nội dung sau nó và caption với hình. Lặp header bảng khi qua trang. Bìa không hiện số trang; phần còn lại đánh số nhất quán. Soát tên, MSSV và liên lạc theo dữ liệu nhóm đã xác nhận.

## 2. Hình và phần giải thích

- Xuất từ nguồn draw.io; dùng vector được công cụ soạn thảo hỗ trợ hoặc PNG đủ nét. Giữ tỉ lệ, tránh ảnh chụp menu/tab editor.
- Rà ở kích thước PDF 100%; tách hình hoặc dùng trang ngang nếu chữ nhỏ. Không ép nhiều sơ đồ vào một trang chỉ để đạt số trang mục tiêu.
- Mỗi hình có caption, được dẫn trong nội dung và có ba phần giải thích: mục đích/thành phần; diễn tiến ví dụ; quy tắc/quyết định/giới hạn.
- GUI ghi rõ ảnh ứng dụng hay wireframe dự kiến; giải thích hành động, validation, chuyển màn hình và lỗi.
- C4 Component hiện tại đã mô tả mười trách nhiệm logic của server theo kiến trúc SignalR mục tiêu. Rà hình và phần giải thích theo đúng phiên bản này; không dùng template Class hoặc swimlane TCP lịch sử như kết quả kiến trúc hiện tại.
- Dùng ba hình Context/concurrency trong `../diagram/c4-report.drawio.xml` và các PNG tương ứng; tối ưu Container/Component đang chờ duyệt riêng. Không coi hai phần concurrency là hai server.
- [ ] Chèn Context, rồi Container/Component khi có bản đạt yêu cầu, rồi concurrency phần 1 và phần 2 trên hai trang kế tiếp. Chiều rộng ảnh khoảng 16 cm trên A4 dọc; giữ tỉ lệ và chừa chỗ caption.
- [ ] Rà chữ trên PDF ở 100% sau chèn; mục tiêu nhãn chính khoảng 11–12 pt. Không thu nhỏ toàn bộ overview để thay cho hai hình nối tiếp.
- [ ] Mục 2.4 có 2,5 trang; tổng mục tiêu nội bộ 25 trang và các vị trí dự kiến được cập nhật đồng bộ với đề cương.
- Khi chỉnh draw.io, đọc [hướng dẫn tại gốc repository](../../AGENTS.md), bảo toàn trang và legend ngoài phạm vi. XML hợp lệ chưa chứng minh hình đẹp; phải rà bản render.

## 3. Ma trận yêu cầu và đầu ra

| Nội dung cần có | Vị trí theo đề cương | Đã kiểm tra |
| --- | --- | --- |
| Mục tiêu, hai chế độ và yêu cầu môn học | Chương 1 | [ ] |
| Core/supporting/generic subdomains | 1.4, bảng ngắn | [ ] |
| C4 Context, Container, server Component | 2.1–2.3, ba sơ đồ và giải thích | [ ] |
| Đa kết nối, async I/O và room ordering | 2.4, hai phần concurrency nối tiếp | [ ] |
| Phân lớp mạng, kênh/cổng và hợp đồng thông điệp trên SignalR | 2.5, hình và bảng contract | [ ] |
| Server có CSDL, dữ liệu và bảo mật | 2.6 | [ ] |
| User stories có flow minh họa | 3.1 | [ ] |
| Luồng/trạng thái hai chế độ | 3.2–3.3 | [ ] |
| Tương tác client–server | 3.4, sequence nét vẽ | [ ] |
| GUI và giải thích | 3.5 | [ ] |
| Ít nhất hai client: thiết kế và trạng thái kiểm chứng | 2.2, 2.4, 4.3 | [ ] |
| Tiến độ, đóng góp và kiểm chứng thực tế | Chương 4 | [ ] |
| Kết luận đúng tiến độ | Chương 5 | [ ] |
| Thông tin liên lạc trưởng nhóm | Bìa | [ ] |
| Nguồn tham khảo liên quan | Cuối báo cáo | [ ] |

Các flow và sơ đồ dùng draw.io theo yêu cầu môn học. Internet là điểm cộng; chỉ ghi đã hoạt động khi có bằng chứng. Có sơ đồ không có nghĩa phần mềm đã vượt qua kiểm thử.

## 4. Checklist nội dung

- [ ] Hợp đồng lời gọi Hub/sự kiện SignalR thống nhất giữa hình, văn bản, ví dụ và kết luận; tên, chiều, payload, điều kiện và lỗi được mô tả rõ.
- [ ] SignalR phụ trách transport/framing; không trình bày frame TCP tự viết trong PDF cũ như giao thức gameplay hiện tại.
- [ ] Tài khoản dùng HTTPS/JSON; gameplay dùng SignalR với HTTPS khởi tạo, WSS hoặc HTTPS dự phòng; Minimal API và Hub cùng tiến trình ASP.NET Core. Cổng và cấu hình được ghi đúng trạng thái xác nhận.
- [ ] Trạng thái phòng nằm ngoài Hub; xử lý tuần tự theo phòng, queue gửi giới hạn và lọc người nhận được mô tả là trách nhiệm ứng dụng, không phải bảo đảm tự động của SignalR.
- [ ] Yêu cầu network stack do nhóm tự phát triển được giữ nguyên; việc dùng SignalR đáp ứng yêu cầu này chưa được coi là đã chấp nhận khi thiếu xác nhận của giảng viên.
- [ ] Context, Container và concurrency overview thống nhất phạm vi không tích hợp Google Identity; phần giải thích và ảnh xuất phản ánh đúng phạm vi này.
- [ ] Phân biệt prototype với mục tiêu; Minimal API, SignalR, EF Core, queue và Google sign-in không bị mô tả là đã có hoặc đã kiểm thử khi thiếu bằng chứng.
- [ ] Quyền vẽ, keyword, start, vote và kết thúc nhất quán giữa bảng luật và flow.
- [ ] Luật chưa chốt được nêu rõ; không còn hai phương án trái nhau cùng được trình bày là chính thức.
- [ ] Không còn mục rỗng; các sơ đồ có giải thích đủ để theo dõi một tình huống.
- [ ] Ba mức C4 đúng phạm vi; concurrency không bị gọi là mức C4 thứ tư.
- [ ] Hình/bảng có số, caption và tham chiếu đúng.
- [ ] Mọi tuyên bố đã làm/đã test có bằng chứng; kịch bản chưa chạy ghi rõ.
- [ ] Không bịa phân công, đóng góp, số liệu hoặc kết quả kiểm thử.
- [ ] Tham khảo truy xuất được và được dùng trong bài; bỏ nguồn VO₂ không liên quan.

## 5. Checklist PDF cuối

- [ ] Mở chính file sẽ nộp, rà từng trang ở 100%.
- [ ] Không cắt chữ, tràn bảng, hình mờ, nhãn chồng hoặc caption rời hình.
- [ ] Tiêu đề, số trang, mục lục và trang ngang hiển thị đúng.
- [ ] Font tiếng Việt không lỗi; tìm/copy một đoạn văn thành công.
- [ ] Không còn comment, track changes, placeholder nội bộ hoặc trang trắng bất thường.
- [ ] Rà “TODO”, “TBD”, “giả định”, “chưa chốt”: xử lý ghi chú nháp nhưng giữ công khai các vấn đề thực sự còn mở.
- [ ] Kiểm tra ví dụ lời gọi/sự kiện, payload và thông tin hiển thị theo vai; không còn ví dụ frame TCP cũ được trình bày như giao thức SignalR.
- [ ] Mở bằng trình xem thứ hai hoặc thiết bị khác nếu có.
- [ ] Lưu nguồn, hình và PDF; xác định rõ bản cuối, tên file mới dùng chữ thường.
- [ ] Tải đúng bản, mở lại bản đã tải lên khi có thể và lưu xác nhận nộp.

Có thể dùng pdfinfo/pdftotext để hỗ trợ rà số trang/văn bản; vẫn cần kiểm tra hình bằng mắt. Mọi lần xuất lại sau sửa phải rà các trang bị ảnh hưởng.

## 6. Phiếu chốt bản nộp

| Mục | Kết quả điền khi thực hiện |
| --- | --- |
| Link nguồn | Chưa điền |
| Tên PDF, giờ xuất, số trang | Chưa điền |
| Các quyết định còn mở công bố trong bài | Chưa điền |
| Kết quả rà nội dung và hình thức | Chưa kiểm tra |
| Lỗi chặn nộp còn lại | Chưa kiểm tra |
| Nơi nộp, giờ nộp, bằng chứng | Chưa nộp |

Không đánh dấu sẵn vì đã có kế hoạch. Điều kiện hoàn tất là đủ nội dung yêu cầu, không còn mâu thuẫn cốt lõi, PDF đọc được và tiến độ được trình bày trung thực.
