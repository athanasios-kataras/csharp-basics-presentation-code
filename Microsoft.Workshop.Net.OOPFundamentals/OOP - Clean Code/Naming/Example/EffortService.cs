public class EffortService {
    public int CalculateEffort(int[] t) {
        int s = 0;
        for (int j = 0; j < 34; j++) {
            s += (t[j] * 4) / 5;
        }
        return s;
    }

    public int GetEffortInManWeeks(int[] taskEfforts) {
        int realDaysPerIdealDay = 4;
        const int WORK_DAYS_PER_WEEK = 5;
        int sum = 0;
        for (int j = 0; j < taskEfforts.Length; j++) {
            int realTaskDays = taskEfforts[j] * realDaysPerIdealDay;
            int realTaskWeeks = (realTaskDays / WORK_DAYS_PER_WEEK);
            sum += realTaskWeeks;
        }
        return sum;
    }
}