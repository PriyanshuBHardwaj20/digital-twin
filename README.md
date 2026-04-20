## How to run -

- I have provided WebBuild and WindowsBuild for this project

- To run the WindowsBuild, download this repo on a Windows computer and open WindowsBuild folder , then double click the "Digital Twin" application to run the build, press Alt+F4 to exit.

- To run the WebBuild, open this link - https://play.unity.com/en/games/342c75c9-15e3-48a2-a606-a43ea216108d/webbuild and press Play to run the build.

## Project Overview: Hospital Room Digital Twin
This project is a high-fidelity 3D Digital Twin (DT) concept developed in Unity to simulate patient health monitoring environments. It serves as the Physical-Digital Interface for the SMILE methodology, focusing on real-time visualization of physiological data.

### Core System Architecture
The project is built on three technical pillars:

Spatial Foundation (Unity URP): A geometrically accurate 3D hospital environment created using primitive-based modeling for optimized performance.

Vitals Simulation Engine: A UI-driven system that allows users to manipulate key patient metrics (Heart Rate, Temperature) via a control dashboard.

Visual Feedback Loop (C# State Machine): A dynamic script that processes vitals in real-time, mapping numerical data to visual states (color interpolation) to signify patient health status.

### SMILE Methodology Alignment: Phase 1
In the context of the S.M.I.L.E. (Sustainable Methodology for Impact Lifecycle Emulation) framework, this project represents Phase 1: Reality Emulation.

Objective: Creating a "Shared Reality Canvas."

Implementation: By establishing the 3D hospital room, the project defines the "where" and "what" of the sociotechnological ecosystem. It creates the spatial-temporal foundation required before moving to data concurrency (Phase 2).

Validation: The use of sliders acts as a manual "Minimal Viable Twin" (MVT) to validate the visual logic before integrating live physical sensors.

### Technical Features
Dynamic Material Interpolation: Patient assets change color (Green to Red) using HSV/RGB lerping based on threshold values defined in the Vitals Manager.

Cross-Platform Ready: Optimized for both standard desktop display and potential AR/VR deployment using the Universal Render Pipeline (URP).
