const ctx = document.getElementById('Users');

new Chart(ctx, {
    type: 'bar',
    data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1,
            backgroundColor: ['red', 'blue', 'yellow', 'green', 'purple', 'orange'],
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});


document.addEventListener("DOMContentLoaded", function () {
    // โหลดข้อมูลจาก Controller
    fetch(UrlChartResign)
        .then(response => response.json())
        .then(data => {
            // สร้างกราฟ
            var ctx = document.getElementById('resign').getContext('2d');
            new Chart(ctx, {
                type: 'bar',
                data: data, 
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }
            });
        });
});