string TrafficLight (int minutes) {
    if (minutes % 5 < 3)
        return "The green light is on";
    else
        return "The red light is on";
}

Console.WriteLine(TrafficLight(9));