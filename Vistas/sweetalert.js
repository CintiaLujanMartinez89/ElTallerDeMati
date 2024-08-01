// JavaScript source code
// Scripts/sweetalert.js
function showAlert(message) {
    Swal.fire({
      // title: 'Alerta',
        text: message,
        icon: 'success',
        showConfirmButton: false, // No muestra el botón de confirmar
        timer: 2000, // El mensaje se cierra después de 3 segundos
        timerProgressBar: false, // Muestra la barra de progreso del temporizador
        didOpen: () => {
            Swal.showLoading();
        },
        willClose: () => {
            Swal.hideLoading();
        }
    });
}
