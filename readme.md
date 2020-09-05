# Reason Envelope Modifier

This is a project dedicated to a DAW called [Reason](https://reasonstudios.com), which contains these 2 nifty devices that has user defined envelopes.
The devices are called [Europa Shapeshifting Synthesizer](https://www.reasonstudios.com/en/reason/instruments/europa), and [Grain Sample Manipulator](https://www.reasonstudios.com/en/reason/instruments/grain)
I wanted to take advantage of this, and make sharp sounding waveforms, but because of how small the box is for editing 


## IF YOU WANT TO CONTRIBUTE, READ THIS PLEASE
For those who want to contribute to the project, and you do not have a copy of Reason, you can use the online Europa player
Located here [https://www.reasonstudios.com/europa-player](https://www.reasonstudios.com/europa-player)
The device is the same as if you were actually using it in Reason

Download the init patch (Basically the whole device is reset)
Remember, the file extension needs to be .repatch
https://github.com/flleeppyy/Reason-Envelope-Modifier/blob/master/Init%20Patch.repatch

The .repatch is in an XML format, which details what parameters have what values.
There are 4 curves, all of which are in HEX format,
Theres a 5th curve that is just a long line of 70707070707070.. and I'm not sure what it does.

## HEX bytes

#Diagram

![Diagram that is very shit](https://)

#Value guide

```
Bytes 1-5 are 01 = off; 02 or greater = on
Byte 1: Beat sync
Byte 2: Key Trigger
Byte 3: Loop
Byte 4: Bipolar
Byte 5: Global
Byte 6: Sustain marker position

The following three are for creating points in the envelope.
This is basically a template.

First byte: X position
Second Byte: Y position
Third Byte: Curve that leads off to the next point (Maximum user defined value=A1, Maximum Value=C8; Anything greater will not have any effect)


Sync rates are defined earlier in the document, with their values as regular integers.
0 = 8 Bar
1 = 4 Bar
2 = 3 Bar
3 = 2 Bar
4 = 7/4
and so on...

```