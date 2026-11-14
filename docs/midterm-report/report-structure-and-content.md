# Đề cương và hướng dẫn nội dung báo cáo giữa kỳ

Cập nhật: 13/11/2026. Đề tài Draw & Guess — NT106.R12.

Đề cương đã thống nhất gồm năm chương, sử dụng C4 Context, Container và Component phía server. Dung lượng chuẩn để biên soạn là **25 trang, gồm bìa và tài liệu tham khảo, chưa tính phụ lục**. Đây là hướng dẫn biên soạn; các luật chơi và chi tiết kỹ thuật chưa được xác nhận vẫn phải được ghi rõ là dự kiến hoặc chưa chốt.

Tài liệu liên quan: [thiết kế chế độ Imposter](imposter-mode-design.md), [quy chuẩn và checklist](formatting-and-review-checklist.md), [PDF v0](BAOCAO_GIUAKY-v0.pdf).

## Phân bổ số trang

Số trang dưới đây là yêu cầu dung lượng nội bộ cho bản báo cáo này, không phải quy định số trang đã được giảng viên xác nhận. Phân bổ đã bao gồm sơ đồ, bảng, caption và phần giải thích. Ưu tiên đủ nội dung và hình đọc được; nếu cần tăng trang, cập nhật lại bảng phân bổ thay vì thu nhỏ chữ hoặc cắt giải thích.

| Phần | Số trang mục tiêu | Vị trí trong PDF dự kiến |
| --- | --- | --- |
| Phần đầu: bìa, tóm tắt, mục lục | 3 | 1–3 |
| Chương 1. Tổng quan và yêu cầu | 3 | 4–6 |
| Chương 2. Kiến trúc hệ thống và truyền thông | 9 | 7–15 |
| Chương 3. Luồng trò chơi và giao diện | 6 | 16–21 |
| Chương 4. Tiến độ và phối hợp | 2 | 22–23 |
| Chương 5. Kết luận | 1 | 24 |
| Tài liệu tham khảo | 1 | 25 |
| **Tổng, chưa tính phụ lục** | **25** | **1–25** |

Vị trí trên tính theo thứ tự trang PDF, bao gồm bìa, không phụ thuộc cách hiển thị số trang ở chân trang. Dự kiến phần đầu dùng một trang bìa, một trang tóm tắt và một trang mục lục. Nếu mục lục hoặc danh mục hình cần thêm chỗ, tăng phần đầu tương ứng và cập nhật tổng.

### Phân bổ chi tiết trong các chương

| Mục | Số trang mục tiêu | Cách sử dụng |
| --- | --- | --- |
| 1.1. Mục tiêu và phạm vi | 0,5 | Bài toán, điểm nổi bật và giới hạn phạm vi |
| 1.2. Hai chế độ chơi | 1 | Bảng so sánh, thuật ngữ và luật còn mở |
| 1.3. Yêu cầu và ràng buộc | 1 | Yêu cầu chức năng và ràng buộc môn học |
| 1.4. Miền con | 0,5 | Bảng core/supporting/generic và giải thích |
| **Tổng Chương 1** | **3** | |
| 2.1. C4 Context | 1 | Một hình và giải thích ranh giới/tương tác |
| 2.2. C4 Container | 1 | Một hình, kênh giao tiếp và hiện trạng/mục tiêu |
| 2.3. C4 Component | 1,5 | Một hình và giải thích trách nhiệm, phụ thuộc |
| 2.4. Concurrency | 2,5 | Hai hình nối tiếp, tình huống mẫu, ordering và cleanup |
| 2.5. Network stack và protocol | 2 | Hình phân lớp, kênh/cổng và bảng hợp đồng thông điệp |
| 2.6. Dữ liệu và bảo mật | 1 | Bảng hoặc ERD nhỏ, lưu trữ và phân quyền |
| **Tổng Chương 2** | **9** | |
| 3.1. User stories và flow ứng dụng | 1 | Flow và bảng tiêu chí chấp nhận ngắn |
| 3.2. Normal | 1 | Flow/state và diễn giải luật |
| 3.3. Imposter | 1 | Flow/state, thông tin theo vai và các thời hạn |
| 3.4. Tương tác client–server | 1 | Sequence nét vẽ, luồng hợp lệ và từ chối |
| 3.5. GUI | 2 | Nhóm màn hình và giải thích hành động/trạng thái |
| **Tổng Chương 3** | **6** | |
| 4.1. Tiến độ | 0,5 | Bảng trạng thái và bằng chứng |
| 4.2. Phối hợp và đóng góp | 0,5 | Bảng đóng góp thực tế |
| 4.3. Kiểm chứng | 0,5 | Kịch bản và kết quả thực tế |
| 4.4. Công việc còn lại | 0,5 | Ưu tiên và giới hạn |
| **Tổng Chương 4** | **2** | |
| Chương 5. Kết luận | 1 | Kết quả, hạn chế và bước tiếp theo |

Các mục 0,5 hoặc 1,5 trang có thể nối tiếp nhau trên cùng trang; không chèn trang trắng để đạt định mức. Phụ lục là tùy chọn, dự kiến 0–3 trang ngoài tổng 25 trang; chỉ chứa schema dài hoặc bằng chứng bổ sung, không chuyển các sơ đồ bắt buộc và giải thích chính sang phụ lục để giảm dung lượng thân bài.

## Hình kiến trúc dành cho Google Docs

Nguồn tổng thể vẫn là `../diagram/c4-model.drawio.xml`. Nguồn trình bày báo cáo `../diagram/c4-report.drawio.xml` hiện chỉ có ba trang đã duyệt: Context và hai phần concurrency. Bản trình bày này được dẫn xuất từ kiến trúc tổng thể; khi đổi kiến trúc cần rà lại cả hai nguồn. Tối ưu Container và Component đang chờ, chưa có bản xuất báo cáo mới cho hai mức đó.

| Thứ tự trong báo cáo | Tệp ảnh | Cách đặt |
| --- | --- | --- |
| 2.1 — Context | [c4-context.png](../diagram/c4-context.png) | Một hình trên trang A4 dọc |
| 2.2 — Container | Chờ tối ưu và duyệt riêng | Dùng vị trí dự kiến, chưa coi hình hiện tại đã đạt kích thước nộp |
| 2.3 — Component | Chờ tối ưu và duyệt riêng | Chưa áp dụng phương án chia hình |
| 2.4 — Concurrency, phần 1/2 | [c4-concurrency-1.png](../diagram/c4-concurrency-1.png) | Một trang: tiếp nhận và xử lý theo phòng |
| 2.4 — Concurrency, phần 2/2 | [c4-concurrency-2.png](../diagram/c4-concurrency-2.png) | Trang kế tiếp: phân phối, lưu trữ và dọn dẹp |

Chèn ảnh theo thứ tự trên, giữ tỉ lệ và đặt chiều rộng khoảng 16 cm (vùng nội dung A4 với lề trái 3 cm, phải 2 cm). Mỗi hình có caption ngay dưới; nội dung giải thích dài đặt trước/sau trang hình. Không ép hai phần concurrency vào cùng trang. Nhãn chính được thiết kế khoảng 11–12 pt ở kích thước chèn; rà PDF xuất thực tế ở 100% trước khi chốt. Ảnh PNG xuất 2×, nền trắng, không kèm legend mẫu đầy đủ. Phần 2 có giải thích nét liền/nét đứt liên quan.

Các số 1–6 trên concurrency chỉ thứ tự đọc một action và đường gửi kết quả. Hai phòng có thể tiến triển độc lập; lưu trữ là phụ thuộc bất đồng bộ, không phải bước đồng bộ bắt buộc của mọi action. Theo dõi nhãn “Tiếp phần 1/2” để nối các hình; không hiểu thành các server hoặc pipeline tách biệt.

Tăng mục 2.4 thêm một trang làm tổng mục tiêu thành 25 trang. Đây vẫn là dung lượng biên soạn nội bộ, chưa phải xác nhận của giảng viên. Bản chứng minh bố cục A4 tạo trong `/tmp` chỉ kiểm tra kích thước hình/caption; việc chèn và phân trang thực tế trong Google Docs còn phải kiểm tra.

## Phần đầu báo cáo — 3 trang

- Bìa: trường, khoa, môn/lớp, đề tài, giảng viên, nhóm, thành viên/MSSV và liên lạc trưởng nhóm theo yêu cầu môn học.
- Tóm tắt: khoảng 150–200 từ về mục tiêu, hai chế độ, kiến trúc và tiến độ giữa kỳ.
- Mục lục tự động; danh mục hình/bảng nếu cần. Chỉ giải thích thuật ngữ viết tắt thực sự được dùng.

## Chương 1. Tổng quan và yêu cầu — 3 trang

### 1.1. Mục tiêu và phạm vi

Giới thiệu trò chơi nhiều người, mô hình Client–Server và lý do phù hợp với môn lập trình mạng. Nêu các mục tiêu: đa kết nối, đồng bộ nét vẽ, kiểm tra hành động tại server, quản lý phòng và lưu dữ liệu.

Điểm nổi bật: kết hợp vẽ thời gian thực với chế độ vai trò ẩn. Thách thức thiết kế là duy trì trạng thái chung trong phòng nhưng chỉ gửi từ khóa và vai trò bí mật cho đúng người nhận.

Nêu rõ chức năng nằm trong phạm vi giữa kỳ và chức năng dự kiến sau đó. Không coi quên mật khẩu, Google sign-in, reconnect, bảng xếp hạng hoặc đa server là đã hoàn thành khi chưa có bằng chứng.

### 1.2. Hai chế độ chơi

Dùng một bảng so sánh Normal và Imposter theo: vai trò, người biết từ khóa, quyền vẽ, quyền đoán/bỏ phiếu, chuyển lượt, kết thúc vòng, kết thúc trận và tính điểm. Giải thích rõ “phòng”, “trận”, “vòng” và “lượt”; dùng nhất quán trong toàn báo cáo.

PDF v0 mô tả imposter cũng vẽ. Hướng thiết kế cập nhật trong [tài liệu Imposter](imposter-mode-design.md) dùng gợi ý riêng, hai lượt vẽ đảo thứ tự, thảo luận và tên tạm theo vòng. Cách chọn từ ở Normal, thời điểm kết thúc sau đáp án đúng, hòa phiếu và công thức điểm vẫn cần được xác nhận. Theo dõi các giới hạn và quyết định mở trong tài liệu riêng, không biến tham số thử nghiệm thành luật cuối cùng.

### 1.3. Yêu cầu chức năng và ràng buộc

Liệt kê yêu cầu có mã định danh ngắn cho: tài khoản, phòng, bắt đầu trận, vẽ, đoán, vote/reveal và kết quả. Mỗi yêu cầu nêu hành động, điều kiện và kết quả mong đợi.

Nêu các ràng buộc: ít nhất hai client GUI, server có CSDL, network stack do nhóm tự phát triển, đặc tả ports/message structure và quản lý đa kết nối. Thiết kế còn cần bảo đảm thứ tự cập nhật phòng và bảo vệ thông tin bí mật. Nhóm đã chọn SignalR cho gameplay; cần xác nhận với giảng viên liệu phần nhóm tự xây dựng trên SignalR đáp ứng yêu cầu network stack hay không. Chưa có xác nhận trong tài liệu hiện tại; không tự diễn giải yêu cầu thành chỉ cần thiết kế message. Chỉ đưa con số hiệu năng nếu có mục tiêu được thống nhất hoặc phép đo.

### 1.4. Phân chia miền con

| Nhóm | Miền con | Trách nhiệm |
| --- | --- | --- |
| Cốt lõi | Điều phối trận | Quản lý giai đoạn, lượt, thời hạn và tiến trình trận |
| Cốt lõi | Luật Normal | Người vẽ, đáp án, điều kiện kết thúc và tính điểm |
| Cốt lõi | Luật Imposter | Vai ẩn, phân phối từ khóa, bỏ phiếu và kết quả |
| Cốt lõi | Vẽ cộng tác | Canvas, nét vẽ hợp lệ và cập nhật cho người chơi |
| Hỗ trợ | Sảnh và phòng | Tạo/vào/rời phòng, thành viên, cấu hình và quyền host |
| Hỗ trợ | Từ khóa | Kho từ và lựa chọn từ |
| Hỗ trợ | Kết quả và lịch sử | Lưu và tra cứu kết quả theo luật trò chơi |
| Phổ quát | Danh tính và truy cập | Đăng ký, xác thực và phiên đăng nhập |

Giải thích bằng một đoạn: miền con tổ chức trách nhiệm nghiệp vụ và có thể cùng nằm trong một tiến trình ASP.NET Core. Vai trò drawer/imposter thuộc trò chơi; danh tính đăng nhập thuộc xác thực. SignalR, logging và SQL access là hạ tầng kỹ thuật. Không cần thêm sơ đồ miền riêng trong phiên bản báo cáo rút gọn.

## Chương 2. Kiến trúc hệ thống và truyền thông — 9 trang

### 2.1. C4 mức 1 — System Context

**Hình bắt buộc:** Player, Host và Draw & Guess. Host là vai trò của Player. Không đưa module nội bộ vào hình này.

Giải thích ranh giới hệ thống, tương tác của người chơi/host và vai trò dịch vụ ngoài. Dùng ví dụ người chơi đăng nhập rồi tham gia phòng để minh họa. Nêu trạng thái dự kiến của tích hợp chưa hiện thực.

Context, Container và concurrency overview đã thống nhất loại Google Identity khỏi phạm vi kiến trúc hiện tại. Dùng luồng tài khoản/phiên qua server để giải thích xác thực; Google sign-in chỉ có thể được xem xét lại trong một thay đổi phạm vi riêng, chưa phải chức năng đã có.

### 2.2. C4 mức 2 — Container

**Hình bắt buộc:** WinForms client, ASP.NET Core server, SQL Server và hệ thống bên ngoài liên quan.

Giải thích kiến trúc mục tiêu đã duyệt: WinForms dùng SignalR .NET Client; một tiến trình ASP.NET Core chứa Minimal API và SignalR Hub; SQL Server lưu dữ liệu lâu dài, dự kiến truy cập qua EF Core. Tài khoản/phiên dùng HTTPS/JSON. Gameplay dùng ASP.NET Core SignalR: khởi tạo kết nối qua HTTPS, trao đổi qua WebSockets bảo mật (WSS) khi khả dụng hoặc transport dự phòng qua HTTPS.

Server sở hữu trạng thái có thẩm quyền; trạng thái phòng đang hoạt động ở bộ nhớ, bên ngoài các Hub instance. Container hiện dùng một tiến trình server, chưa đưa Redis vào kiến trúc hiện tại. HTTPS/WSS và EF Core là lựa chọn thiết kế, chưa phải kết quả triển khai hoặc kiểm thử.

Nêu ngắn gọn lý do lựa chọn công nghệ. Thêm bảng “prototype hiện có / kiến trúc mục tiêu”: checkout đã khảo sát có client gọi thư viện auth dùng SqlClient trực tiếp, khác với kiến trúc mục tiêu qua server. EF Core trong log là lựa chọn thiết kế, không phải bằng chứng hiện thực.

### 2.3. C4 mức 3 — Component phía server

**Hình bắt buộc:** dùng trang C4 Component hiện tại trong draw.io; trang này đã được cập nhật với mười trách nhiệm logic của game server. Đây là sơ đồ kiến trúc mục tiêu, chưa phải bằng chứng các component đã được lập trình.

Mười trách nhiệm đã thể hiện: xác thực/phiên; gameplay Hub; sảnh/phòng; xử lý tuần tự theo phòng và điều phối trận; luật Normal; luật Imposter; canvas; chọn từ khóa/gợi ý; phân phối sự kiện có lọc người nhận; lưu trữ. Đối chiếu phần giải thích với đúng hướng phụ thuộc trong sơ đồ.

Giải thích ranh giới trách nhiệm và hướng phụ thuộc. Minh họa một action đi từ SignalR Hub qua kiểm tra phiên/phòng, hàng đợi phòng và luật chơi rồi tạo sự kiện gửi tới người nhận hợp lệ. Nêu rằng tách component không đồng nghĩa mỗi component chạy một thread hoặc một service riêng.

Không cần C4 mức 4 hay sơ đồ lớp chi tiết cho báo cáo giữa kỳ này.

### 2.4. Mô hình đa kết nối và xử lý đồng thời

**Hình bắt buộc:** hai phần nối tiếp của concurrency trong nguồn xuất báo cáo: phần 1 mô tả tiếp nhận/định tuyến và xử lý theo phòng; phần 2 mô tả lọc người nhận, hàng đợi gửi, lưu trữ và cleanup. Đây là cùng một kiến trúc server, không phải hai tiến trình hoặc mức C4 thứ tư. Overview đầy đủ vẫn được giữ làm nguồn tham chiếu.

Giải thích chuỗi mục tiêu: SignalR nhận lời gọi Hub → kiểm tra action/phiên → định tuyến vào queue của room → xử lý tuần tự và cập nhật trạng thái → lọc người nhận → queue gửi có giới hạn do ứng dụng quản lý → một vòng gửi có thứ tự cho mỗi kết nối qua IHubContext. SignalR phụ trách transport/framing; queue của room, giới hạn queue gửi và thứ tự sự kiện nghiệp vụ là trách nhiệm ứng dụng, không mặc nhiên có sẵn chỉ vì dùng SignalR. Timer và thay đổi thành viên phải đi qua cùng đường xử lý tuần tự của phòng.

Làm rõ task và thread pool, pending I/O không giữ riêng thread chờ, các phòng có thể tiến triển đồng thời nhưng cập nhật một phòng phải có thứ tự. Mô tả client chậm, mất kết nối, cleanup và việc áp dụng kết quả DB ảnh hưởng trạng thái phòng.

Dùng tình huống A và B cùng phòng, C ở phòng khác để giải thích. Không đồng thời mô tả lock và room queue như một cơ chế đã hiện thực nếu chưa có bằng chứng hoặc giải thích khác biệt.

### 2.5. Network stack và giao thức ứng dụng

**Hình cần có:** mô hình phân lớp từ thông điệp nghiệp vụ và lời gọi/sự kiện SignalR xuống transport WSS hoặc HTTPS dự phòng và các tầng mạng bên dưới. Phân biệt phần nhóm tự xây dựng với phần SignalR cung cấp; mô tả HTTPS/JSON cho tài khoản bên cạnh kênh gameplay.

Gồm bảng kênh/cổng và bảng hợp đồng thông điệp ứng dụng ngắn theo miền con. Mỗi lời gọi Hub hoặc sự kiện server gửi cần nêu: tên/ý nghĩa, chiều, điều kiện phiên/vai/vòng/giai đoạn, trường dữ liệu và ràng buộc, phản hồi/lỗi và yêu cầu thứ tự. Tên method, event và schema cụ thể phải được thống nhất với người phụ trách giao thức; chưa coi ví dụ đề xuất là API đã triển khai. Chuyển schema dài sang phụ lục nếu cần.

Theo thiết kế hiện tại, SignalR phụ trách giao thức Hub và framing của transport. Không thêm lớp `Length 4 byte + JSON` hoặc `Type 1 byte` như giao thức gameplay đang được chọn. PDF v0 còn hai mô tả frame TCP mâu thuẫn; cần thay phần này khi biên soạn lại PDF theo SignalR, thay vì chọn một trong hai làm kiến trúc hiện hành.

Giải thích kiểm tra payload, giới hạn kích thước, sai quyền/giai đoạn, thứ tự action/sự kiện và xử lý lỗi kết nối. Phân biệt cơ chế giữ kết nối của SignalR với deadline của trò chơi. Cổng triển khai, giới hạn queue/payload, timeout và chính sách reconnect phải được đối chiếu với quyết định hoặc code; không mang cổng TCP 5000 hay thông số cũ sang như cấu hình đã chốt.

Yêu cầu môn học về network stack do nhóm tự phát triển vẫn cần giảng viên xác nhận đối với cách dùng SignalR. Báo cáo phải trình bày phần nhóm tự làm như hợp đồng thông điệp, kiểm tra action, định tuyến phòng, điều phối trạng thái và phân phối dữ liệu; chưa được tuyên bố lựa chọn này đã được chấp nhận.

### 2.6. Dữ liệu và bảo mật

Dùng bảng dữ liệu hoặc ERD nhỏ khi quan hệ cần minh họa. Phân biệt dữ liệu trong bộ nhớ với dữ liệu lưu lâu dài; bảng đã có với bảng đề xuất. Mô tả thời điểm đọc/ghi tài khoản, từ khóa và kết quả.

Giải thích băm mật khẩu, xác thực phiên, phân quyền gameplay, bảo vệ keyword/role và việc truy cập CSDL qua server ở kiến trúc mục tiêu. Không gọi băm mật khẩu là mã hóa có thể giải mã. Không tuyên bố TLS hoặc Google sign-in đã hoạt động khi thiếu bằng chứng.

## Chương 3. Luồng trò chơi và giao diện — 6 trang

### 3.1. User stories và luồng ứng dụng

**Hình bắt buộc:** flow ứng dụng từ bắt đầu → đăng ký/đăng nhập → trang chủ → chọn chế độ/phòng → phòng chờ → game → kết quả.

Lập 3–4 user stories tiêu biểu: đăng nhập, tạo/vào phòng, chơi Normal và chơi Imposter. Mỗi story có tiêu chí chấp nhận và chỉ rõ nhánh trong flow minh họa nó. Thêm nhánh lỗi tài khoản, phòng không hợp lệ và mất kết nối khi liên quan. Không cần lặp một flow giống nhau cho từng story.

### 3.2. Chế độ Normal

**Hình bắt buộc:** flow hoặc state diagram thể hiện vòng chơi theo luật đã chốt.

Giải thích ai được vẽ, ai biết từ, ai được đoán, khi nào đổi lượt, hết giờ và tính điểm. Với mỗi chuyển trạng thái, nêu sự kiện, điều kiện và kết quả. Giữ rõ các quyết định chưa chốt như kết thúc khi có người đoán đúng và cách so khớp tiếng Việt.

### 3.3. Chế độ Imposter

Dùng [thiết kế Imposter cập nhật](imposter-mode-design.md) làm cơ sở: keyword/gợi ý theo vai, vẽ hai lượt với thứ tự đảo ngược, tên tạm cố định trong vòng, thảo luận rồi vote. Các quy tắc thắng và xử lý ngoại lệ còn mở phải được ghi rõ.

**Hình bắt buộc:** flow hoặc state diagram thể hiện phân vai, cấp từ riêng tư, vẽ, vote, reveal và kết quả theo luật được xác nhận.

Giải thích thông tin mỗi vai nhìn thấy, quyền hành động theo giai đoạn, thời điểm bỏ phiếu và chuyển vòng. Không suy ra luật hòa, thắng/thua hoặc quyền vẽ đồng thời từ một hình thiếu chi tiết.

### 3.4. Tương tác client–server tiêu biểu

**Hình bắt buộc:** sequence diagram cho một nét vẽ: client gửi → server xác thực người chơi và phase/turn → cập nhật canvas → phát sự kiện cho đúng người nhận → client hiển thị.

Nêu nhánh từ chối action không hợp lệ. Có thể thêm sequence cho cấp vai/từ hoặc vote nếu phần bí mật chưa được giải thích đủ; không cần thêm nhiều sơ đồ lặp lại.

### 3.5. Thiết kế giao diện

Nhóm hình theo bốn nhóm: tài khoản; chọn phòng/phòng chờ; gameplay Normal/Imposter; kết quả. Tái sử dụng ảnh phù hợp trong PDF, bổ sung wireframe cho màn hình chưa có.

Mỗi hình ghi rõ ảnh prototype hay thiết kế dự kiến; giải thích mục tiêu, controls chính, validation, chuyển màn hình, cập nhật từ server và trạng thái lỗi. Nêu khác biệt hiển thị keyword/vote theo vai. Không để wireframe của imposter hiển thị từ khóa bí mật.

## Chương 4. Tiến độ và phối hợp — 2 trang

### 4.1. Tiến độ theo chức năng hoặc miền con

Bảng gồm: hạng mục, trạng thái, bằng chứng và phần còn thiếu. Dùng “có code”, “đã kiểm thử”, “thiết kế dự kiến” hoặc “chưa chốt”. Có code không đồng nghĩa đã kiểm thử thành công.

Khảo sát checkout ngày 12/11/2026 ghi nhận WinForms, AuthService, PasswordHasher, SqlClient và migration Users; đây là quan sát lịch sử, cần cập nhật từ các nhánh thực tế trước khi nộp. Bảng tiến độ phải cung cấp bằng chứng riêng cho Minimal API, SignalR Hub/client, room queue, phân phối bí mật và EF Core; sơ đồ và log quyết định kiến trúc không chứng minh các phần này đã được hiện thực hoặc kiểm thử.

### 4.2. Phối hợp và đóng góp

Ghi các nhóm công việc, đầu ra, phụ thuộc tích hợp và đóng góp thực tế theo yêu cầu môn học. Đề cương/kế hoạch này không phân công tên người; bảng đóng góp cuối do nhóm điền theo việc thực sự đã làm.

### 4.3. Kiểm chứng

Bảng ngắn: kịch bản, điều kiện, kết quả mong đợi, kết quả thực tế và bằng chứng. Ưu tiên hai client cùng phòng, đồng bộ vẽ, thứ tự action trong phòng, các phòng tiến triển độc lập, input/payload không hợp lệ, sai quyền/giai đoạn, keyword riêng tư, client chậm và mất kết nối. Kiểm chứng thao tác ứng dụng qua SignalR thay cho kế hoạch kiểm thử bộ đọc frame TCP tự viết; mọi kiểm thử transport riêng cần có phạm vi và bằng chứng tương ứng. Ghi “chưa chạy” khi chưa kiểm thử; không tạo số đo hoặc kết quả pass.

### 4.4. Công việc còn lại

Liệt kê các quyết định mở, thiếu sót hiện thực và kiểm chứng cần làm trước cuối kỳ, theo mức ưu tiên.

## Chương 5. Kết luận — 1 trang

Tóm tắt kết quả thiết kế và hiện thực đã xác minh; nêu giới hạn và bước tiếp theo. Không kể toàn bộ mục tiêu như kết quả đã hoàn thành.

## Tài liệu tham khảo — 1 trang; phụ lục tùy chọn — 0–3 trang

Chỉ dẫn nguồn thực sự được đọc và dùng: tài liệu môn học, tài liệu chính thức cho C4, ASP.NET Core SignalR, .NET, HTTPS/WebSockets, định dạng dữ liệu hoặc bảo mật tương ứng nội dung bài. Bỏ bài VO₂ không liên quan trong PDF. Mỗi nguồn có tên, tổ chức/tác giả, thông tin truy xuất và chỗ dẫn trong bài; không tự tạo trích dẫn.

Phụ lục chỉ dùng khi cần cho schema message dài, bảng dữ liệu chi tiết hoặc bằng chứng kiểm thử. Dùng Component đã cập nhật; không đưa template Class hoặc swimlane TCP lịch sử vào như kiến trúc SignalR hiện tại.

## Cách giải thích mỗi sơ đồ

1. **Mục đích và thành phần:** câu hỏi hình trả lời, phạm vi, các thành phần và trách nhiệm.
2. **Diễn tiến cụ thể:** lần theo mũi tên hoặc chuyển trạng thái bằng một tình huống trong game.
3. **Quy tắc và quyết định:** quyền, thứ tự, bí mật, lỗi, lý do chọn thiết kế và phần chưa xác nhận.

Context có thể giải thích ngắn; concurrency/protocol cần nhiều chi tiết hơn. Mỗi hình có caption, được dẫn trong bài và ghi rõ hiện trạng hay thiết kế mục tiêu. Chương 1 định nghĩa yêu cầu; Chương 2 giao trách nhiệm; Chương 3 minh họa thực thi để tránh lặp nội dung.
