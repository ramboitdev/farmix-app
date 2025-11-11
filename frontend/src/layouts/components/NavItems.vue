<script lang="ts" setup>
import VerticalNavSectionTitle from '@/@layouts/components/VerticalNavSectionTitle.vue'
import VerticalNavGroup from '@layouts/components/VerticalNavGroup.vue'
import VerticalNavLink from '@layouts/components/VerticalNavLink.vue'
</script>

<template>
  <!-- Dashboards -->
  <VerticalNavGroup
    :item="{
      title: 'Dashboards',
      icon: 'bx-home-smile',
    }"
  >
    <VerticalNavLink
      :item="{
        title: 'Analytics',
        to: '/dashboard',
      }"
    />
  </VerticalNavGroup>
  <VerticalNavSectionTitle
    :item="{
      heading: 'Autres',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Account Settings',
      icon: 'bx-user',
      to: '/account-settings',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Login',
      icon: 'bx-log-in',
      to: '/login',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Register',
      icon: 'bx-user-plus',
      to: '/register',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Error',
      icon: 'bx-info-circle',
      to: '/no-existence',
    }"
  />
  <VerticalNavSectionTitle
    :item="{
      heading: 'User Interface',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Typography',
      icon: 'bx-text',
      to: '/typography',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Icons',
      icon: 'bx-package',
      to: '/icons',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Cards',
      icon: 'bx-credit-card',
      to: '/cards',
    }"
  />

  <!-- 👉 Forms & Tables -->
  <VerticalNavSectionTitle
    :item="{
      heading: 'Forms & Tables',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Form Layouts',
      icon: 'bx-layout',
      to: '/form-layouts',
    }"
  />
  <VerticalNavLink
    :item="{
      title: 'Tables',
      icon: 'bx-table',
      to: '/tables',
    }"
  />
</template>
