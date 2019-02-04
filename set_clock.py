#!/usr/bin/env python3
# -*- coding: utf-8 -*-

# George Smart, M1GEO
# 29 Jan 2019.

# Written in Python 3


import sys
import serial
import time
from datetime import datetime

clock_baud_rate = 115200

print("George Smart, M1GEO")
print("Simple Clock Setting Script")

try:
	clock_port = sys.argv[1]
except Exception as e:
	print("Sorry, failed to understand specified port")
	print("Expected format:")
	print("\t%s <COM_DEVICE>" % sys.argv[0])
	exit(-1)

print("Using clock on port: %s" % clock_port)

try:
	s = serial.Serial(port=clock_port, baudrate=clock_baud_rate)
	s.write(b"\n") # send newline to open the comport
except Exception as e:
	print("Oops. Something failed opening clock port '%s'" % clock_port)
	print(str(e))
	exit(-1)

time.sleep(5) # wait for MCU to restart and be ready.

today = datetime.today()
dy = today.year
dm = today.month
dd = today.day

th = today.hour
tm = today.minute
ts = today.second

clock_payload = "%04u,%02u,%02u,%02u,%02u,%02u," % (dy, dm, dd, th, tm, ts)

print("Date: %02u/%02u/%04u" % (dd, dm, dy))
print("Time: %02u:%02u:%02u" % (th, tm, ts))
print("Payl: '%s'" % clock_payload)
try:
	t_str = "%s\n" % clock_payload
	s.write(t_str.encode())
except Exception as e:
	print("Oops. Something failed uploading '%s'" % clock_payload)
	print(str(e))
	exit(-1)
