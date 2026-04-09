import { createRouter, createWebHistory, type RouteRecordRaw } from 'vue-router';

// Importing components
import CarePlanNavigation from '../components/CarePlanNavigation.vue';
import MedicationTracking from '../components/MedicationTracking.vue';
import AppointmentTracking from '../components/AppointmentTracking.vue';
import ChecklistCompletion from '../components/ChecklistCompletion.vue';
import EducationalResources from '../components/EducationalResources.vue';
import Journaling from '../components/Journaling.vue';
import CareTeamContactManagement from '../components/CareTeamContactManagement.vue';
import Login from '../components/Login.vue';

const routes: Array<RouteRecordRaw> = [
  { path: '/login', component: Login },
  { path: '/care-plan', component: CarePlanNavigation },
  { path: '/medication-tracking', component: MedicationTracking },
  { path: '/appointment-tracking', component: AppointmentTracking },
  { path: '/checklist-completion', component: ChecklistCompletion },
  { path: '/educational-resources', component: EducationalResources },
  { path: '/journaling', component: Journaling },
  { path: '/care-team-contacts', component: CareTeamContactManagement },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;