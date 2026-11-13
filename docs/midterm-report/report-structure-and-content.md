# Đề cương và hướng dẫn nội dung báo cáo giữa kỳ

Cập nhật: 13/11/2026. Đề tài Draw & Guess — NT106.R12.

Đề cương đã thống nhất gồm năm chương, sử dụng C4 Context, Container và Component phía server. Dung lượng chuẩn để biên soạn là **24 trang, gồm bìa và tài liệu tham khảo, chưa tính phụ lục**. Đây là hướng dẫn biên soạn; các luật chơi và chi tiết kỹ thuật chưa được xác nhận vẫn phải được ghi rõ là dự kiến hoặc chưa chốt.

Tài liệu liên quan: [thiết kế chế độ Imposter](imposter-mode-design.md), [quy chuẩn và checklist](formatting-and-review-checklist.md), [PDF v0.1](BAOCAO_GIUAKI-v0.1.pdf).

## Phân bổ số trang

Số trang dưới đây là yêu cầu dung lượng nội bộ cho bản báo cáo này, không phải quy định số trang đã được giảng viên xác nhận. Phân bổ đã bao gồm sơ đồ, bảng, caption và phần giải thích. Ưu tiên đủ nội dung và hình đọc được; nếu cần tăng trang, cập nhật lại bảng phân bổ thay vì thu nhỏ chữ hoặc cắt giải thích.

| Phần | Số trang mục tiêu | Vị trí trong PDF dự kiến |
| --- | --- | --- |
| Phần đầu: bìa, tóm tắt, mục lục | 3 | 1–3 |
| Chương 1. Tổng quan và yêu cầu | 3 | 4–6 |
| Chương 2. Kiến trúc hệ thống và truyền thông | 8 | 7–14 |
| Chương 3. Luồng trò chơi và giao diện | 6 | 15–20 |
| Chương 4. Tiến độ và phối hợp | 2 | 21–22 |
| Chương 5. Kết luận | 1 | 23 |
| Tài liệu tham khảo | 1 | 24 |
| **Tổng, chưa tính phụ lục** | **24** | **1–24** |

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
| 2.4. Concurrency | 1,5 | Một hình, tình huống mẫu, ordering và cleanup |
| 2.5. Network stack và protocol | 2 | Hình stack/frame, ví dụ byte và bảng message |
| 2.6. Dữ liệu và bảo mật | 1 | Bảng hoặc ERD nhỏ, lưu trữ và phân quyền |
| **Tổng Chương 2** | **8** | |
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

Các mục 0,5 hoặc 1,5 trang có thể nối tiếp nhau trên cùng trang; không chèn trang trắng để đạt định mức. Phụ lục là tùy chọn, dự kiến 0–3 trang ngoài tổng 24 trang; chỉ chứa schema dài hoặc bằng chứng bổ sung, không chuyển các sơ đồ bắt buộc và giải thích chính sang phụ lục để giảm dung lượng thân bài.

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

PDF v0.1 mô tả imposter cũng vẽ. Hướng thiết kế cập nhật trong [tài liệu Imposter](imposter-mode-design.md) dùng gợi ý riêng, hai lượt vẽ đảo thứ tự, thảo luận và tên tạm theo vòng. Cách chọn từ ở Normal, thời điểm kết thúc sau đáp án đúng, hòa phiếu và công thức điểm vẫn cần được xác nhận. Theo dõi các giới hạn và quyết định mở trong tài liệu riêng, không biến tham số thử nghiệm thành luật cuối cùng.

### 1.3. Yêu cầu chức năng và ràng buộc

Liệt kê yêu cầu có mã định danh ngắn cho: tài khoản, phòng, bắt đầu trận, vẽ, đoán, vote/reveal và kết quả. Mỗi yêu cầu nêu hành động, điều kiện và kết quả mong đợi.

Nêu các ràng buộc: ít nhất hai client GUI, server có CSDL, giao thức ứng dụng do nhóm thiết kế, đa kết nối, thứ tự cập nhật phòng và bảo vệ thông tin bí mật. Chỉ đưa con số hiệu năng nếu có mục tiêu được thống nhất hoặc phép đo.

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

Giải thích bằng một đoạn: miền con tổ chức trách nhiệm nghiệp vụ và có thể cùng nằm trong một tiến trình ASP.NET Core. Vai trò drawer/imposter thuộc trò chơi; danh tính đăng nhập thuộc xác thực. TCP, logging và SQL access là hạ tầng kỹ thuật. Không cần thêm sơ đồ miền riêng trong phiên bản báo cáo rút gọn.

## Chương 2. Kiến trúc hệ thống và truyền thông — 8 trang

### 2.1. C4 mức 1 — System Context

**Hình bắt buộc:** Player, Host, Draw & Guess và Google Identity nếu còn trong phạm vi thiết kế. Host là vai trò của Player. Không đưa module nội bộ vào hình này.

Giải thích ranh giới hệ thống, tương tác của người chơi/host và vai trò dịch vụ ngoài. Dùng ví dụ người chơi đăng nhập rồi tham gia phòng để minh họa. Nêu trạng thái dự kiến của tích hợp chưa hiện thực.

### 2.2. C4 mức 2 — Container

**Hình bắt buộc:** WinForms client, ASP.NET Core server, SQL Server và hệ thống bên ngoài liên quan.

Giải thích kênh HTTPS cho tài khoản/phiên và TCP cho gameplay theo kiến trúc đã ghi trong log. Minimal API và TCP listener cùng tiến trình server. Server sở hữu trạng thái có thẩm quyền; phòng đang hoạt động ở bộ nhớ, dữ liệu lâu dài ở CSDL.

Nêu ngắn gọn lý do lựa chọn công nghệ. Thêm bảng “prototype hiện có / kiến trúc mục tiêu”: checkout đã khảo sát có client gọi thư viện auth dùng SqlClient trực tiếp, khác với kiến trúc mục tiêu qua server. EF Core trong log là lựa chọn thiết kế, không phải bằng chứng hiện thực.

### 2.3. C4 mức 3 — Component phía server

**Hình bắt buộc:** sơ đồ thành phần thực sự của game server. Trang Component hiện có trong draw.io là template và cần được thiết kế lại trước khi đưa vào báo cáo.

Các trách nhiệm cần thể hiện: xác thực/phiên, kết nối TCP và định tuyến message, quản lý phòng, điều phối trận, luật Normal/Imposter, xử lý vẽ, chọn từ và truy cập dữ liệu/kết quả. Có thể nhóm trách nhiệm khi phù hợp; không bắt buộc một component cho mỗi miền con.

Giải thích ranh giới trách nhiệm và hướng phụ thuộc. Minh họa một action đi từ connection handler qua kiểm tra phiên/phòng/luật rồi tạo sự kiện gửi ra. Nêu rằng tách component không đồng nghĩa mỗi component chạy một thread hoặc một service riêng.

Không cần C4 mức 4 hay sơ đồ lớp chi tiết cho báo cáo giữa kỳ này.

### 2.4. Mô hình đa kết nối và xử lý đồng thời

**Hình bắt buộc:** concurrency overview. Đây là góc nhìn hỗ trợ, không phải mức C4 thứ tư.

Giải thích chuỗi: nhận bất đồng bộ → đọc/kiểm tra message → định tuyến → queue của room → xử lý tuần tự → lọc người nhận → queue gửi có giới hạn → send loop theo thứ tự.

Làm rõ task và thread pool, pending I/O không giữ riêng thread chờ, các phòng có thể tiến triển đồng thời nhưng cập nhật một phòng phải có thứ tự. Mô tả client chậm, mất kết nối, cleanup và việc áp dụng kết quả DB ảnh hưởng trạng thái phòng.

Dùng tình huống A và B cùng phòng, C ở phòng khác để giải thích. Không đồng thời mô tả lock và room queue như một cơ chế đã hiện thực nếu chưa có bằng chứng hoặc giải thích khác biệt.

### 2.5. Network stack và giao thức ứng dụng

**Hình cần có:** mô hình tầng mạng và cấu trúc frame; có thể ghép hai hình nhỏ trên một trang nếu vẫn đọc được.

Gồm bảng kênh/cổng, một đặc tả framing thống nhất, ví dụ byte và bảng message ngắn theo miền con. Mỗi message nêu chiều, điều kiện phiên/vai/giai đoạn, payload và phản hồi/lỗi. Chuyển schema dài sang phụ lục nếu cần.

PDF đang mâu thuẫn giữa JSON toàn thân và Type nhị phân một byte. Nhóm phải chốt một cách rồi đồng bộ hình, văn bản và ví dụ. Nếu chọn `Length 4 byte big-endian + JSON UTF-8`, N là số byte body, không gồm header. Ví dụ body chính xác `{"type":"PING","payload":{}}` dài 28 byte, header `00 00 00 1C`, tổng frame 32 byte. Ví dụ này minh họa phương án JSON, chưa xác nhận đó là giao thức đã triển khai.

Giải thích đọc thiếu frame, nhiều frame trong một lần đọc, kích thước tối đa, JSON lỗi, sai quyền/giai đoạn, heartbeat/timeout và thứ tự gửi. Phân biệt frame ứng dụng với TCP segment/IP packet. Cổng 5000 và mọi giá trị timeout/queue limit cần được đối chiếu với quyết định hoặc code.

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

Khảo sát checkout ngày 12/11/2026 thấy WinForms, AuthService, PasswordHasher, SqlClient và migration Users; chưa thấy triển khai TCP server/room queue trong `src`. Đây là quan sát giới hạn ở checkout đó, cần cập nhật từ các nhánh thực tế trước khi nộp.

### 4.2. Phối hợp và đóng góp

Ghi các nhóm công việc, đầu ra, phụ thuộc tích hợp và đóng góp thực tế theo yêu cầu môn học. Đề cương/kế hoạch này không phân công tên người; bảng đóng góp cuối do nhóm điền theo việc thực sự đã làm.

### 4.3. Kiểm chứng

Bảng ngắn: kịch bản, điều kiện, kết quả mong đợi, kết quả thực tế và bằng chứng. Ưu tiên hai client cùng phòng, đồng bộ vẽ, frame bị chia/gộp, input sai quyền, keyword riêng tư và mất kết nối. Ghi “chưa chạy” khi chưa kiểm thử; không tạo số đo hoặc kết quả pass.

### 4.4. Công việc còn lại

Liệt kê các quyết định mở, thiếu sót hiện thực và kiểm chứng cần làm trước cuối kỳ, theo mức ưu tiên.

## Chương 5. Kết luận — 1 trang

Tóm tắt kết quả thiết kế và hiện thực đã xác minh; nêu giới hạn và bước tiếp theo. Không kể toàn bộ mục tiêu như kết quả đã hoàn thành.

## Tài liệu tham khảo — 1 trang; phụ lục tùy chọn — 0–3 trang

Chỉ dẫn nguồn thực sự được đọc và dùng: tài liệu môn học, tài liệu chính thức cho C4, .NET, TCP/JSON hoặc bảo mật tương ứng nội dung bài. Bỏ bài VO₂ không liên quan trong PDF. Mỗi nguồn có tên, tổ chức/tác giả, thông tin truy xuất và chỗ dẫn trong bài; không tự tạo trích dẫn.

Phụ lục chỉ dùng khi cần cho schema message dài, bảng dữ liệu chi tiết hoặc bằng chứng kiểm thử. Không đưa template Component/Class chưa sửa vào như thiết kế hoàn chỉnh.

## Cách giải thích mỗi sơ đồ

1. **Mục đích và thành phần:** câu hỏi hình trả lời, phạm vi, các thành phần và trách nhiệm.
2. **Diễn tiến cụ thể:** lần theo mũi tên hoặc chuyển trạng thái bằng một tình huống trong game.
3. **Quy tắc và quyết định:** quyền, thứ tự, bí mật, lỗi, lý do chọn thiết kế và phần chưa xác nhận.

Context có thể giải thích ngắn; concurrency/protocol cần nhiều chi tiết hơn. Mỗi hình có caption, được dẫn trong bài và ghi rõ hiện trạng hay thiết kế mục tiêu. Chương 1 định nghĩa yêu cầu; Chương 2 giao trách nhiệm; Chương 3 minh họa thực thi để tránh lặp nội dung.
