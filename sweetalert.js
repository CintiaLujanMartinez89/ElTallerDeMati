// JavaScript source code
// Scripts/sweetalert.js
function showAlert(message) {
    Swal.fire({
        title: 'Alerta',
        text: message,
        icon: 'info',
        showConfirmButton: false, // No muestra el botón de confirmar
        timer: 3000, // El mensaje se cierra después de 3 segundos
        timerProgressBar: true, // Muestra la barra de progreso del temporizador
        didOpen: () => {
            Swal.showLoading();
        },
        willClose: () => {
            Swal.hideLoading();
        }
    });
}
