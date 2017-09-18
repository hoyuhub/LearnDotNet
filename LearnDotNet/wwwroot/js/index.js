$(function () {
    $.getJSON('Home/EasyData', function (data) {
        console.info(data);
        $('#container').highcharts({
            title: {
                text: '郑先生的资金流动',
                x: -20
            },
            subtitle: {
                text: '数据来源: 人工智障',
                x: -20
            },
          
            tooltip: {
                valueSuffix: '￥'
            },
            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'middle',
                borderWidth: 0
            },
            series: [{
                name: '花销',
                data: data
            }]
        })
    })
})
