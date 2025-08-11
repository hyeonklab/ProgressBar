using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarTest
{
    public partial class FormProgressBar : Form
    {
        private CancellationTokenSource _cts; // Cancellation token source

        /// <summary>
        /// ProgressBar 폼 생성자
        /// </summary>
        public FormProgressBar()
        {
            InitializeComponent();

            _cts = new CancellationTokenSource();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            Text = "work status";
        }

        /// <summary>
        /// 시작 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            ControlBox = false; // 닫기 버튼 비활성화
            btnStart.Enabled = false;
            btnCancel.Enabled = true;

            progressBar.Value = 0;
            lblMessage.Text = "작업 시작...";

            try
            {
                await Task.Run(() => DoWork(_cts.Token));
                lblMessage.Text = "작업 완료";
            }
            catch (OperationCanceledException) // 취소 예외 처리
            {
                lblMessage.Text = $"{lblMessage.Text} 작업 취소됨";

                if (MessageBox.Show("프로그레스 바 창을 닫으시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
                else
                    ControlBox = true; // 닫기 버튼 활성화
            }
            finally
            {
                btnStart.Enabled = true;
                btnCancel.Enabled = false;
            }
        }

        /// <summary>
        /// 취소 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel(); // 취소 요청
        }

        /// <summary>
        /// 클릭시 작업을 수행하는 메서드
        /// </summary>
        /// <param name="token"></param>
        private void DoWork(CancellationToken token)
        {
            for (int i = 0; i <= 100; i++)
            {
                token.ThrowIfCancellationRequested(); // 취소 요청 확인 및 예외 발생

                if (lblMessage.IsDisposed) // 컨트롤 삭제되었는지 확인
                    return;

                // UI 업데이트 (UI 스레드 호출)
                Invoke(new Action(() =>
                {
                    progressBar.Value = i;
                    lblMessage.Text = $"{i}% 진행 중...";
                }));

                Thread.Sleep(50); // 실제 작업 대체
            }
        }
    }
}
