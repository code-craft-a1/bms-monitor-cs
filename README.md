# Programming Paradigms

Health Monitoring Systems

[Here is an article that helps to understand the Adult Vital Signs](https://en.wikipedia.org/wiki/Vital_signs)

[Here is a reference to Mideical monitoring](https://en.wikipedia.org/wiki/Monitoring_(medicine))

## Purpose
Continuous monitoring of vital signs, such as respiration and heartbeat, plays a crucial role in early detection and even prediction of conditions that may affect the wellbeing of the patient. 

Health Monitoring System (HMS) is a smart and multi-layer solution that enables health data transfer from a patient’s wearable device to the doctor’s mobile application. 

Both the systems require accurate reading of the vitals and immediate alarming when reading is out of range.

## Issues

- The code here has high complexity in a single function.
- The code is not modularised 
- The tests are not complete - they do not cover all the needs of a consumer

## Tasks

1. Reduce the cyclomatic complexity.
1. Separate pure functions from I/O
1. Avoid duplication - functions that do nearly the same thing
1. Complete the tests - cover all conditions. 
1. To take effective action, we need to know
the abnormal measure and the breach -
whether high or low. Currently this has been printed and alarmed on the console. 
Provide ways to be able to extend the vitals reading and the alarm state to be sent to external device (say a doctors mobile app) 

## The Exploration

How well does our code hold-out in the rapidly evolving [WHDS](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC6111409/)
Can we add new functionality without disturbing the old?

## The Landscape

- New vital might emerge to be monitored (ex: SPO2 during pandemic)
- Vendor might provide additional vital reading (blood pressure)
- Limits may change based on age of patient
- Predicting the future requires Astrology!

## Keep it Simple

Shorten the Semantic distance

- Procedural to express sequence
- Functional to express relation between input and output
- Object oriented to encapsulate state with actions
- Apect oriented to capture repeating aspects
