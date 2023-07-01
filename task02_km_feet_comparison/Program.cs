string KmFeetComparison (double kms, double feet) {
    double feetinkms = kms * 1000 / 0.305;
    if (feet > feetinkms) {
        return $"the distance in feet ({feet}ft) is longer than in kms ({kms}km)";
    }
    else if (feetinkms > feet) {
        return $"the distance in kms ({kms}km) is more than in feet ({feet}ft)";
    }
    else return "the distances are equal";
}

Console.WriteLine(KmFeetComparison(1, 3000));