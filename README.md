# unifi-adopter
Setting up a new Unifi device and using a hosted Unifi Controller? With these small tools you can set the necessary URLs in the device to reach your Controller.

## Usage
To adopt a new device just connect it with your LAN and power it up.
It will request an IP from your DHCP-Server, look it up!
### Graphical User Interface
1. Start up the UnifiAdopter.exe
2. Enter the IP of the device
3. Enter the Inform-URL of your Unifi Controller
4. Press the "Adopt"-Button or hit Enter
### Command Line Interface
1. Open a command prompt in the directory of UnifiAdopter.exe
2. Start the Adopter with the following parameters:
`UnifiAdopter.exe $DEVICEIP $CONTROLLERURL`
