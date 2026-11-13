# Thiết kế chế độ Imposter

Cập nhật: 13/11/2026. Tài liệu ghi lại hướng thiết kế sau khi thảo luận, phục vụ [đề cương báo cáo](report-structure-and-content.md). Đây là thiết kế gameplay, chưa phải xác nhận tính năng đã hiện thực hoặc đã cân bằng qua kiểm thử.

## 1. Mục tiêu của chế độ chơi

Người chơi thường biết đáp án chính xác. Imposter biết mình là người giả mạo nhưng chỉ nhận thông tin gợi ý. Imposter phải dùng gợi ý, quan sát nét vẽ và giải thích hành động để hòa nhập với những người biết đáp án.

Người chơi thường quan sát đóng góp của từng người, thảo luận và bỏ phiếu tìm imposter. Việc imposter suy ra đáp án trong lúc chơi không tự động kết thúc vòng; mục tiêu của họ vẫn là tránh bị nhận diện.

## 2. Từ khóa và gợi ý riêng tư

Quy tắc chung: người chơi thường nhận từ khóa đầy đủ; imposter nhận gợi ý rộng hơn, đủ để tạo một đóng góp hợp lý nhưng không trực tiếp tiết lộ đáp án.

| Loại đáp án | Người chơi thường thấy | Imposter thấy |
| --- | --- | --- |
| Cụm từ | Bánh sinh nhật | ____ sinh nhật |
| Một từ | Mèo | Thú cưng trong nhà |
| Từ/cụm từ khác | Pizza | Món ăn có thể chia sẻ trong một buổi tiệc |

Với cụm từ, có thể dùng cụm khuyết làm gợi ý. Với đáp án không thể tách thành cụm khuyết có nghĩa, dùng gợi ý ngữ nghĩa. Phân loại theo ý nghĩa, không chỉ theo số khoảng trắng trong tiếng Việt.

Chuẩn bị từng cặp `đáp án — gợi ý`, không tự động che ngẫu nhiên ký tự. Một gợi ý tốt có nhiều đáp án hợp lý. Ví dụ “thú cưng trong nhà” có thể gợi đến mèo, chó hoặc loài vật khác. Các ví dụ trên cần được chơi thử để kiểm tra độ khó.

Người chơi thường chỉ cần thấy đáp án đầy đủ; không áp dụng luật bắt mọi người vẽ theo cùng một cụm khuyết ở lượt đầu. Server chỉ gửi dữ liệu được phép tới từng người, không gửi đáp án cho imposter rồi ẩn bằng giao diện.

## 3. Cấu trúc vòng chơi

| Giai đoạn | Hành vi |
| --- | --- |
| Chuẩn bị | Server chọn từ khóa/gợi ý, phân vai, gán tên tạm và xác định thứ tự vẽ |
| Lượt vẽ thứ nhất | Từng người lần lượt đóng góp vào canvas chung, kể cả imposter |
| Lượt vẽ thứ hai | Mỗi người đóng góp thêm một lần, theo thứ tự đảo ngược |
| Thảo luận | Khóa canvas; người chơi trao đổi trong thời gian giới hạn; hết giờ tự động chuyển sang bỏ phiếu |
| Bỏ phiếu | Chọn người bị nghi thông qua tên tạm của vòng hiện tại |
| Công bố | Hiển thị imposter, đáp án và kết quả bỏ phiếu theo luật thắng đã thống nhất |
| Chuyển tiếp | Nếu còn vòng: xóa canvas, chọn từ/vai và tên tạm mới; nếu hết trận: hiển thị kết quả trận |

Ví dụ thứ tự:

```text
Lượt thứ nhất: A → B → C → D
Lượt thứ hai:  D → C → B → A
```

Người vẽ đầu lượt thứ nhất được quan sát nhiều nhất trước đóng góp thứ hai. Người vẽ cuối lượt thứ nhất nhận thứ tự ngược lại. Quy tắc áp dụng cho tất cả, không đổi vị trí dựa trên ai là imposter.

Đây là cách giảm bất lợi của người vẽ đầu, không bảo đảm mọi vị trí có lợi thế bằng nhau. Cần thử nghiệm mức độ lộ đáp án sau từng đóng góp. Người D có hai đóng góp liên tiếp ở điểm đổi chiều; phải xem việc này có làm lộ quá nhiều thông tin hay không khi chơi thử.

## 4. Giới hạn lượt vẽ

Đề xuất ban đầu để thử nghiệm: mỗi lượt một nét liên tục, có thời hạn; chỉ người đang tới lượt được vẽ. Một nét là thao tác nhấn chuột, di chuyển và thả chuột, không đồng nghĩa một gói TCP.

Không cho người chơi xóa nét của người khác. Ghi nhận người tạo mỗi nét và hiển thị tên tạm của người đang vẽ để người chơi có bằng chứng khi thảo luận. Giới hạn nét, thời gian và chính sách khi hết giờ chưa có giá trị cuối cùng; xem danh sách quyết định mở.

## 5. Ví dụ imposter vẽ đầu

Đáp án là “mèo”; imposter chỉ thấy “thú cưng trong nhà”.

1. Imposter vẽ một bàn chân, phù hợp với nhiều loài thú cưng.
2. Những người tiếp theo thêm chi tiết dựa trên từ “mèo”.
3. Sau khi thứ tự đảo chiều, imposter có thêm thông tin trước lượt thứ hai và có thể thêm một chi tiết phù hợp hơn.
4. Khi thảo luận, người khác có thể nghi ngờ nét đầu quá chung chung hoặc nét sau giống hành vi bắt chước. Imposter phải giải thích lựa chọn của mình.
5. Mọi người bỏ phiếu, sau đó server công bố vai và đáp án.

Điểm quan trọng là khả năng hòa nhập, không phải giữ cho imposter hoàn toàn không đoán được từ. Ngược lại, nếu hình vẽ luôn tiết lộ đáp án quá sớm thì cần chỉnh gợi ý, giới hạn đóng góp hoặc kho từ.

## 6. Tên tạm theo vòng

Mỗi người có tên tạm mới ở đầu vòng, chẳng hạn Cáo, Cú, Gấu, Thỏ. Tên phải duy nhất trong vòng và giữ nguyên qua cả vẽ, thảo luận, bỏ phiếu và công bố.

Chỉ thay tên khi bắt đầu vòng kế tiếp. Đổi tên ngay trước thảo luận hoặc bỏ phiếu sẽ khiến người chơi không xác định được ai tạo nét vẽ nào.

Server giữ định danh tài khoản/người chơi ổn định để quản lý kết nối, điểm và lịch sử. Tên hiển thị tạm là dữ liệu của vòng. Nhãn nét vẽ, người gửi chat và lựa chọn bỏ phiếu đều dùng cùng ánh xạ này.

Tên tạm giúp giảm việc bỏ phiếu theo quan hệ quen biết, nhưng không bảo đảm ẩn danh hoàn toàn: phong cách vẽ hoặc cách viết có thể tiết lộ người chơi. Cách hiển thị avatar và bảng điểm phải được thống nhất nếu muốn hạn chế các dấu hiệu nhận diện khác.

## 7. Thảo luận và bỏ phiếu

Thảo luận diễn ra sau khi hoàn tất vẽ. Người chơi giải thích đóng góp và đặt câu hỏi về nét đáng nghi. Luật đề xuất: không nói, đánh vần hoặc trực tiếp tiết lộ đáp án. Đây là quy tắc xã hội; chưa có thiết kế tự động nhận diện mọi cách tiết lộ từ khóa.

**Giới hạn thời gian thảo luận:** thời lượng được cấu hình trước khi trận bắt đầu và giữ cố định trong trận; số giây cụ thể cần được chọn sau khi chơi thử. Khi chuyển vào giai đoạn thảo luận, server thiết lập thời điểm kết thúc và thông báo cho các client hiển thị đồng hồ đếm ngược. Canvas tiếp tục bị khóa trong suốt giai đoạn này.

Khi hết thời gian, server tự động đóng thảo luận và chuyển sang bỏ phiếu, không chờ người chơi hoặc host xác nhận. Các tin nhắn thảo luận đã gửi vẫn có thể đọc, nhưng server không nhận thêm tin nhắn thảo luận sau khi giai đoạn kết thúc. Thời điểm xử lý và trạng thái tại server quyết định việc chấp nhận tin nhắn; đồng hồ trên client chỉ phục vụ hiển thị. Bộ đếm bỏ phiếu là bộ đếm riêng, bắt đầu khi server mở giai đoạn bỏ phiếu.

Đề xuất dùng bỏ phiếu kín, chỉ công bố sau khi đóng phiếu để hạn chế bắt chước lựa chọn của người khác. Người chơi chọn tên tạm; server xác thực người bỏ phiếu, mục tiêu và vòng/giai đoạn hiện tại.

Các đề xuất trước về hòa phiếu, phiếu trắng, tự bỏ phiếu, điểm và điều kiện thắng chưa được chốt riêng. Không coi chúng là luật chính thức chỉ vì đã được nêu trong thảo luận.

## 8. Trách nhiệm thiết kế hệ thống

| Phần | Trách nhiệm |
| --- | --- |
| Luật Imposter | Phân vai, quyền nhận từ/gợi ý, điều kiện vote và xác định kết quả theo luật được chốt |
| Điều phối trận | Giai đoạn, thứ tự hai lượt, deadline và chuyển vòng |
| Vẽ cộng tác | Canvas, người tạo nét, giới hạn thao tác và phát cập nhật hợp lệ |
| Quản lý từ khóa | Lưu/chọn cặp từ khóa và gợi ý đã chuẩn bị |
| Danh tính và phòng | Giữ ID ổn định, thành viên và ánh xạ tên tạm của vòng |
| Kết quả | Ghi kết quả bằng ID ổn định theo quy tắc điểm được chốt |

Mọi action phải được kiểm tra tại server theo vòng, giai đoạn và người được phép. Canvas khóa sau giai đoạn vẽ; phiếu chỉ được nhận trong giai đoạn bỏ phiếu. Việc đổi tên không tạo phiên đăng nhập mới.

Khi cập nhật báo cáo: dùng phần này ở mục 1.2 về luật, 2.3 về trách nhiệm component, 2.5 về message, 3.3 về flow/state và 3.5 về GUI. Chưa sửa draw.io hoặc triển khai code từ tài liệu này.

## 9. Các quyết định cần chốt và kiểm chứng

| Nội dung | Cần quyết định/kiểm chứng |
| --- | --- |
| Số người | Số tối thiểu/tối đa và số imposter; ví dụ hiện dùng một imposter |
| Giới hạn vẽ | Chốt một nét mỗi lượt hay giới hạn khác; cách xử lý nét đang vẽ khi hết giờ |
| Thời gian | Chọn số giây cho lượt vẽ, thảo luận và vote; thảo luận đã xác định có giới hạn và tự chuyển sang vote khi hết giờ |
| Thứ tự | Chọn người đầu vòng và cách phân phối vị trí qua nhiều vòng |
| Kết quả | Đa số tương đối/tuyệt đối, hòa phiếu, bỏ phiếu trắng và điểm |
| Quyền vote | Có tự vote, đổi phiếu hoặc xem phiếu sớm không |
| Mất kết nối | Rời phòng, host rời, thiếu người, khôi phục hay hủy vòng |
| Hiển thị | Avatar, bảng điểm và thời điểm hiện danh tính tài khoản |
| Độ khó | Gợi ý quá dễ/quá khó, imposter vẽ đầu/cuối, hai đóng góp liên tiếp khi đảo thứ tự |

Chơi thử với người thật trước khi gọi chế độ là cân bằng. Ghi nhận thời điểm imposter đoán ra từ, mức độ hợp lý của đóng góp đầu tiên, khả năng giải thích và kết quả vote. Không tạo số liệu hoặc kết quả thử nghiệm khi chưa thực hiện.
