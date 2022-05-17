COMPONENTS:

- Raspberry Pi 4 Model B https://www.raspberrypi.com/products/raspberry-pi-4-model-b/
- Servomotor https://cleste.ro/servo-motor-pdi-1171mg-digital.html?utm_medium=GoogleAds&utm_campaign=&utm_source=&gclid=CjwKCAjwj42UBhAAEiwACIhADhs2m1WmMcpUBOLvBPVbQSRDuC45F0KikVZfEnLWVF-kh8Q17ATeDBoC6a0QAvD_BwE
- PIR Motion Sensor https://cleste.ro/modul-senzor-infrarosu-pir.html
- Jumper wires
- Raspbery Pi Camera v2 https://www.emag.ro/camera-raspberry-pi-v2-cl485/pd/DGKW04BBM/?cmpid=87002&gclid=CjwKCAjwj42UBhAAEiwACIhADvwL2FPIElk_5RDda-lOjFciCUQ56ZufPS1DojTdPcugxUHwI1vH9BoCxu8QAvD_BwE
- Breadboard https://cleste.ro/breadboard-400-puncte.html
- Power Source for breadboard  https://cleste.ro/sursa-alimentare-breadboard-xd-42.html

Building:

- connect raspberry pi camera into the camera module
- servomotor: connect ground and power cables to the breadboard and pwm cable to pwm pin on raspberry
- connect a ground cable from raspberry to breadboard so they have a common ground
- connect ground and power cable from pir motions sensor to raspberry pi pins #4 and #6, and out-pin to the #11 pin
- connect power source to the breadboard

Running:

- after installing the application, type `dotnet CatToyTestApp.dll`
- then a text menu will appear
- press 1 to test the photo, 2 to test the video, 3 to test the motion sensor and 4 to test the servomotor

